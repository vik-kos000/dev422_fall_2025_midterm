using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grpc.Net.Client;
using AlbumInventory.Protos;
using Grpc.Core;

namespace AlbumInventoryClient
{
    public partial class MainForm : Form
    {
        private readonly AlbumService.AlbumServiceClient _client;
        private readonly GrpcChannel _channel;
        public MainForm()
        {
            InitializeComponent();
            // Optional: You can set the initial status message here
            lblStatus.Text = "Status: Ready";

            // Initialize gRPC client
            var serverUrl = "https://localhost:58629"; // Your gRPC server URL
            _channel = GrpcChannel.ForAddress(serverUrl);
            _client = new AlbumService.AlbumServiceClient(_channel);

            // Load albums on startup
            _ = LoadAlbums();
        }
        private async Task LoadAlbums()
        {
            try
            {
                var call = _client.ListAlbums(new ListAlbumsRequest());
                var albums = new List<Album>();
                while (await call.ResponseStream.MoveNext())
                {
                    var album = call.ResponseStream.Current;
                    albums.Add(album);
                }


                // Bind to DataGridView
                dgvAlbums.DataSource = null;
                dgvAlbums.DataSource = albums;
            }
            catch (RpcException ex)
            {
                MessageBox.Show($"gRPC Error: {ex.Status.StatusCode} - {ex.Status.Detail}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ClearForm()
        {
            txtId.Text = "";
            txtTitle.Text = "";
            txtArtist.Text = "";
            txtGenre.Text = "";
            txtYear.Text = "";
            chkAvailable.Checked = false;

            lblStatus.Text = "Ready for new entry";
        }
        // ADD ALBUM BUTTON CLICK
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var album = new Album
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = txtTitle.Text,
                    Artist = txtArtist.Text,
                    Genre = txtGenre.Text,
                    Year = int.TryParse(txtYear.Text, out var y) ? y : 0,
                    Available = chkAvailable.Checked
                };

                var resp = await _client.AddAlbumAsync(new AddAlbumRequest { Album = album });
                MessageBox.Show($"Album '{resp.Album.Title}' added successfully!");
                await LoadAlbums();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding album: {ex.Message}");
            }

        }
        // ADD UPDATE BUTTON
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var album = new Album
                {
                    Id = txtId.Text,
                    Title = txtTitle.Text,
                    Artist = txtArtist.Text,
                    Genre = txtGenre.Text,
                    Year = int.TryParse(txtYear.Text, out var y) ? y : 0,
                    Available = chkAvailable.Checked
                };

                var resp = await _client.UpdateAlbumAsync(new UpdateAlbumRequest { Album = album });
                MessageBox.Show($"Album '{resp.Album.Title}' updated successfully!");
                await LoadAlbums();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating album: {ex.Message}");
            }

        }
        // ADD DELETE BUTTON
        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = txtId.Text;
                var resp = await _client.DeleteAlbumAsync(new DeleteAlbumRequest { Id = id });
                MessageBox.Show($"Album '{resp.Id}' deleted successfully!");
                await LoadAlbums();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting album: {ex.Message}");
            }

        }
        // REFRESH BUTTON
        private async void btn_Refresh_Click(object sender, EventArgs e)
        {
            await LoadAlbums();
            ClearForm();
        }
        private void dgvAlbums_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlbums.SelectedRows.Count == 0) return;

            var album = dgvAlbums.SelectedRows[0].DataBoundItem as Album;
            if (album == null) return;

            txtId.Text = album.Id;
            txtTitle.Text = album.Title;
            txtArtist.Text = album.Artist;
            txtGenre.Text = album.Genre;
            txtYear.Text = album.Year.ToString();
            chkAvailable.Checked = album.Available;
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
