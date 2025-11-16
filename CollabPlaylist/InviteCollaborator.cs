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
    public partial class InviteCollaborator : Form
    {
        private readonly PlaylistService _service = new PlaylistService();

        public InviteCollaborator()
        {
            InitializeComponent();
        }

        private async void InviteCollaborator_Load(object sender, EventArgs e)
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

        private async void button_SendInvite_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = comboBox_PlaylistSelect.SelectedItem as Playlist;
                if (!selected.IsCollaborative)
                {
                    MessageBox.Show("This playlist is not collaborative. Cannot add collaborators.", "Error");
                    return;
                }

                if (selected == null)
                {
                    MessageBox.Show("Please select a playlist first.");
                    return;
                }

                if (!int.TryParse(textBox_InviteUsername.Text.Trim(), out int userId))
                {
                    MessageBox.Show("Enter a numeric user ID.");
                    return;
                }

                await _service.InviteCollaboratorAsync(selected.Id, userId);
                MessageBox.Show($"User {userId} invited to '{selected.Name}'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending invite: " + ex.Message);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
