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
    public partial class AddSong : Form
    {
        private readonly PlaylistService _service = new PlaylistService();

        public AddSong()
        {
            InitializeComponent();
        }

        private async void AddSong_Load(object sender, EventArgs e)
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

        private async void button_AddSong_Click(object sender, EventArgs e)
        {
            try
            {
                // Trim and fetch user input
                string title = textBox_SongTitle.Text.Trim();
                string artist = textBox_Artist.Text.Trim();
                string genre = textBox_Genre.Text.Trim();
                string durationText = textBox_Duration.Text.Trim();

                // Validate required fields
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Song title cannot be empty.", "Validation Error");
                    return;
                }

                if (string.IsNullOrWhiteSpace(artist))
                {
                    MessageBox.Show("Artist cannot be empty.", "Validation Error");
                    return;
                }

                if (string.IsNullOrWhiteSpace(genre))
                {
                    MessageBox.Show("Genre cannot be empty.", "Validation Error");
                    return;
                }

                // Validate playlist selection
                var selectedPlaylist = comboBox_PlaylistSelect.SelectedItem as Playlist;
                if (selectedPlaylist == null)
                {
                    MessageBox.Show("Please select a playlist first.", "Validation Error");
                    return;
                }

                // Duration validation: MM:SS
                var parts = durationText.Split(':');
                if (parts.Length != 2 ||
                    !int.TryParse(parts[0], out int minutes) ||
                    !int.TryParse(parts[1], out int seconds) ||
                    minutes < 0 || seconds < 0 || seconds >= 60)
                {
                    MessageBox.Show("Duration must be in MM:SS format with valid numbers.", "Validation Error");
                    return;
                }

                // Convert duration to total seconds (or keep as string if needed)
                double duration = minutes * 60 + seconds;

                // Create Song object
                var song = new Song
                {
                    Title = title,
                    Artist = artist,
                    Genre = genre,
                    Duration = duration
                };

                // Add song via service
                await _service.AddSongAsync(selectedPlaylist.Id, song);

                MessageBox.Show($"Song '{song.Title}' added to '{selectedPlaylist.Name}'.", "Success");

                // Clear input fields
                textBox_SongTitle.Clear();
                textBox_Artist.Clear();
                textBox_Genre.Clear();
                textBox_Duration.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding song: " + ex.Message, "Error");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
