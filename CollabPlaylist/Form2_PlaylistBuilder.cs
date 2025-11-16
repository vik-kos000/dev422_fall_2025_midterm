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
    public partial class Form2_PlaylistBuilder : Form
    {
        private readonly PlaylistService _service = new PlaylistService();
        private readonly int currentUserId = 1;

        public Form2_PlaylistBuilder()
        {
            InitializeComponent();
        }

        // return home button
        private void button_Return_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }

        private void Form2_PlaylistBuilder_Load(object sender, EventArgs e)
        {
            label_LoggedInUser.Text = $"Logged in as User ID: {currentUserId}";
        }

        private void button_CreatePlaylist_Click(object sender, EventArgs e)
        {
            var createForm = new CreatePlaylist();
            createForm.ShowDialog();
        }

        private void button_AddSong_Click(object sender, EventArgs e)
        {
            var addSongForm = new AddSong();
            addSongForm.ShowDialog();
        }

        private void button_Invite_Click(object sender, EventArgs e)
        {
            var inviteForm = new InviteCollaborator();
            inviteForm.ShowDialog();
        }

        private void button_Vote_Click(object sender, EventArgs e)
        {
            if (dataGridView_Playlists.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a playlist first.", "No Selection");
                return;
            }

            var selectedRow = dataGridView_Playlists.SelectedRows[0];
            if (selectedRow.Cells["PlaylistId"].Value == null)
            {
                MessageBox.Show("Selected playlist has no ID.", "Error");
                return;
            }

            int playlistId = Convert.ToInt32(selectedRow.Cells["PlaylistId"].Value);
            if (playlistId <= 0)
            {
                MessageBox.Show("Invalid playlist ID.", "Error");
                return;
            }

            var votingForm = new Voting(playlistId);
            votingForm.ShowDialog();
        }

        private void button_Rankings_Click(object sender, EventArgs e)
        {
            var rankingsForm = new Rankings();
            rankingsForm.ShowDialog();
        }

        private async void button_Refresh_Click(object sender, EventArgs e)
        {

            try
            {
                var playlists = await _service.GetPlaylistsAsync();

                // clear previous rows only
                dataGridView_Playlists.Rows.Clear();

                // populate the DataGridView with correct columns
                foreach (var p in playlists)
                {
                    dataGridView_Playlists.Rows.Add(
                        p.Id,                        // PlaylistId
                        p.Name,                      // PlaylistName
                        p.CreatedBy,                 // CreatedBy
                        p.Songs.Count,               // SongCount
                        p.IsCollaborative            // IsCollaborative (CheckBox)
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to refresh playlists: {ex.Message}", "Error");
            }
        }
    }
}
