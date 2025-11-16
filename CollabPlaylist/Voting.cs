using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollabPlaylist
{
    public partial class Voting : Form
    {
        private readonly PlaylistService _service = new PlaylistService();
        private readonly int _playlistId;
        public Voting(int playlistId)
        {
            InitializeComponent();
            _playlistId = playlistId;
        }

        private async void Voting_Load(object sender, EventArgs e)
        {
            await LoadSongsGridAsync();
        }

        private async void button_RefreshVotes_Click(object sender, EventArgs e)
        {
            await LoadSongsGridAsync();
        }

        private async Task LoadSongsGridAsync()
        {
            try
            {
                // Fetch songs for the current playlist, including votes
                var songs = await _service.GetRankingsAsync(_playlistId);

                dataGridView_Songs.DataSource = null;
                dataGridView_Songs.AutoGenerateColumns = false;
                dataGridView_Songs.Columns.Clear();

                // Define columns
                dataGridView_Songs.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "SongId",
                    HeaderText = "Song ID",
                    DataPropertyName = "Id",
                    Width = 50
                });
                dataGridView_Songs.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Title",
                    HeaderText = "Song Title",
                    DataPropertyName = "Title",
                    Width = 180
                });
                dataGridView_Songs.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Artist",
                    HeaderText = "Artist",
                    DataPropertyName = "Artist",
                    Width = 120
                });
                dataGridView_Songs.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Votes",
                    HeaderText = "Votes",
                    DataPropertyName = "Votes",
                    Width = 60
                });

                // Vote button column
                var voteCol = new DataGridViewButtonColumn
                {
                    Name = "Vote",
                    HeaderText = "Vote",
                    Text = "+",
                    UseColumnTextForButtonValue = true,
                    Width = 60
                };
                dataGridView_Songs.Columns.Add(voteCol);

                // Bind songs list
                dataGridView_Songs.DataSource = songs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load songs: " + ex.Message);
            }
        }

        private async void dataGridView_Songs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView_Songs.Columns[e.ColumnIndex].Name != "Vote") return;

            try
            {
                int songId = Convert.ToInt32(dataGridView_Songs.Rows[e.RowIndex].Cells["SongId"].Value);
                await _service.VoteSongAsync(_playlistId, songId);
                MessageBox.Show("Vote recorded.");
                await LoadSongsGridAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Voting failed: " + ex.Message);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
