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
    public partial class CreatePlaylist : Form
    {
        private readonly PlaylistService _service = new PlaylistService();

        public CreatePlaylist()
        {
            InitializeComponent();
        }

        private async void button_Create_Click(object sender, EventArgs e)
        {
            try
            {
                var playlist = new Playlist
                {
                    Name = textBox_PlaylistName.Text.Trim(),
                    IsCollaborative = checkBox_Collaborative.Checked,
                    CreatedBy = 1   //  CHANGE TO LOGGED IN USER
                };

                var created = await _service.CreatePlaylistAsync(playlist);
                MessageBox.Show("Playlist '" + created.Name + "' created (ID: " + created.Id + ")", "Success");

                textBox_PlaylistName.Clear();
                checkBox_Collaborative.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Create failed: " + ex.Message, "Error");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
