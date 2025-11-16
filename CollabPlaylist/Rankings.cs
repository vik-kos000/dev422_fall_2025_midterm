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
    public partial class Rankings : Form
    {
        private readonly PlaylistService _service = new PlaylistService();
        public Rankings()
        {
            InitializeComponent();
        }

        private async void Rankings_Load(object sender, EventArgs e)
        {
            try
            {
                var playlists = await _service.GetPlaylistsAsync();
                comboBox_PlaylistSelect.DataSource = playlists;
                comboBox_PlaylistSelect.DisplayMember = "Name";
                comboBox_PlaylistSelect.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load playlists: " + ex.Message);
            }
        }

        private async void button_RefreshRankings_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = comboBox_PlaylistSelect.SelectedItem as Playlist;
                if (selected == null) return;

                var ranked = await _service.GetRankingsAsync(selected.Id);
                dataGridView_Rankings.DataSource = null;
                dataGridView_Rankings.AutoGenerateColumns = false;
                dataGridView_Rankings.Columns.Clear();

                dataGridView_Rankings.Columns.Add(new DataGridViewTextBoxColumn { Name = "Rank", HeaderText = "Rank", Width = 60 });
                dataGridView_Rankings.Columns.Add(new DataGridViewTextBoxColumn { Name = "Title", HeaderText = "Song Title", DataPropertyName = "Title", Width = 200 });
                dataGridView_Rankings.Columns.Add(new DataGridViewTextBoxColumn { Name = "Artist", HeaderText = "Artist", DataPropertyName = "Artist", Width = 140 });
                dataGridView_Rankings.Columns.Add(new DataGridViewTextBoxColumn { Name = "Votes", HeaderText = "Votes", DataPropertyName = "Votes", Width = 80 });

                // Add rows with rank index
                for (int i = 0; i < ranked.Count; i++)
                {
                    var song = ranked[i];
                    dataGridView_Rankings.Rows.Add((i + 1).ToString(), song.Title, song.Artist, song.Votes.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load rankings: " + ex.Message);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
