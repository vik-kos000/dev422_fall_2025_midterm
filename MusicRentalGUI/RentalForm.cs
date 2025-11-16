using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicRentalGUI
{
    public partial class RentalForm : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        public RentalForm()
        {
            InitializeComponent();
        }

        private async void button_addAlbum_Click(object sender, EventArgs e)
        {
            //create an object for the Album. same name as it appears in the API
            var newAlbum = new
            {
                Title = textBox_albumTitle.Text,
                Artist = textBox_albumArtist.Text,
                Genre = textBox_albumGenre.Text,
                Year = textBox_albumYear.Text,
                Available = true
            };

            //manually serialize the object at json
            var json = JsonConvert.SerializeObject(newAlbum);

            //create httpContent with json string
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            //send the post request
            HttpResponseMessage message = await _httpClient.PostAsync("https://localhost:7113/api/Music", content);

            if (message.IsSuccessStatusCode)
            {
                button_listAlbums_Click(sender, e);
                MessageBox.Show("Album Added Successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Failed to add the Album!", "Error");
            }
        }

        private async void button_rentAlbum_Click(object sender, EventArgs e)
        {
            int albumId = int.Parse(textBox_albumID.Text);

            //check if album exists
            HttpResponseMessage albumResponse = await _httpClient.GetAsync($"https://localhost:7113/api/Music/{albumId}");
            if (!albumResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Album not found! Please enter a valid Album ID.", "Error");
                return;
            }
            //deserialize album and check avaliability
            string albumJson = await albumResponse.Content.ReadAsStringAsync();
            var album = JsonConvert.DeserializeObject<Album>(albumJson);

            if (!album.Available)
            {
                MessageBox.Show("This album is currently unavailable for rent.", "Error");
                return;
            }

            //create an object for the rental. same name as it appears in the API
            var newRental = new
            {
                UserId = int.Parse(textBox_userID.Text),
                AlbumId = albumId,
                RentalDate = DateTime.Now,
                Active = true
            };

            //manually serialize the object at json
            var json = JsonConvert.SerializeObject(newRental);

            //create httpContent with json string
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            //send the post request
            HttpResponseMessage message = await _httpClient.PostAsync("https://localhost:7061/api/Rental", content);

            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Album Rented sucessfully!", "Success");
                button_viewActiveRentals_Click(sender, e);

                //update album availability
                album.Available = false; // mark as unavailable
                var updateJson = JsonConvert.SerializeObject(album);
                var updateContent = new StringContent(updateJson, Encoding.UTF8, "application/json");

                HttpResponseMessage updateResponse = await _httpClient.PutAsync($"https://localhost:7113/api/Music/{album.Id}", updateContent);
                if(!updateResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Failed to update avaliablity");
                }
            }
            else
            {
                MessageBox.Show("Failed to Rent the album!", "Error");
            }
        }

        private async void button_returnAlbum_Click(object sender, EventArgs e)
        {
            int albumIdToReturn = int.Parse(textBox_albumID.Text);

            HttpResponseMessage message = await _httpClient.PostAsync($"https://localhost:7061/api/Rental/{albumIdToReturn}/return", null);

            if (message.IsSuccessStatusCode)
            {
                // Get the movie from album API
                HttpResponseMessage getAlbumResponse = await _httpClient.GetAsync($"https://localhost:7113/api/Music/{albumIdToReturn}");
                if (getAlbumResponse.IsSuccessStatusCode)
                {
                    string albumJson = await getAlbumResponse.Content.ReadAsStringAsync();
                    var album = JsonConvert.DeserializeObject<Album>(albumJson);

                    // mark it available again
                    album.Available = true;

                    // send update to album API
                    var updateJson = JsonConvert.SerializeObject(album);
                    var updateContent = new StringContent(updateJson, Encoding.UTF8, "application/json");

                    await _httpClient.PutAsync($"https://localhost:7113/api/Music/{album.Id}", updateContent);

                }
                else
                {
                    MessageBox.Show("Failed to update avaliablity");
                }
                MessageBox.Show("album returned sucessfully!", "Success");
                button_viewActiveRentals_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Failed to return the album!", "Error");
            }
        }

        private async void button_listAlbums_Click(object sender, EventArgs e)
        {
            //clear list box
            listBox_displayInformation.Items.Clear();

            HttpResponseMessage message = await _httpClient.GetAsync("https://localhost:7113/api/Music");

            if (message.IsSuccessStatusCode)
            {
                //read the response message(content) as a string
                string jsonString = await message.Content.ReadAsStringAsync();

                //deserialize the json string into the list of album objects
                var albums = JsonConvert.DeserializeObject<List<Album>>(jsonString);


                foreach (Album album in albums.Where(m => m.Available))
                {
                    listBox_displayInformation.Items.Add($"{album.Id}: {album.Title}, {album.Artist}, {album.Year} - {album.Genre}");
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve album", "Error");
            }
        }

        private async void button_viewActiveRentals_Click(object sender, EventArgs e)
        {
            //clear list box
            listBox_displayInformation.Items.Clear();

            HttpResponseMessage message = await _httpClient.GetAsync("https://localhost:7061/api/Rental/Active");

            if (message.IsSuccessStatusCode)
            {
                //read the response message(content) as a string
                string jsonString = await message.Content.ReadAsStringAsync();

                //deserialize the json string into the list of rental objects
                var rentals = JsonConvert.DeserializeObject<List<Rental>>(jsonString);

                foreach (Rental rental in rentals)
                {
                    listBox_displayInformation.Items.Add($"{rental.UserId}:{rental.AlbumId}, Rental Date:{rental.RentalDate}");
                }
            }
        }

        private async void button_deleteAlbum_Click(object sender, EventArgs e)
        {
            int albumIdToDelete = int.Parse(textBox_albumID.Text);

            // Get the album from album API
            HttpResponseMessage deleteResponse = await _httpClient.DeleteAsync($"https://localhost:7113/api/Music/{albumIdToDelete}");

            //delete the album from rental API
            HttpResponseMessage deleteRentalResponse = await _httpClient.DeleteAsync($"https://localhost:7061/api/Rental/{albumIdToDelete}");

            if (deleteResponse.IsSuccessStatusCode && deleteRentalResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("album/rentals deleted sucessfully!", "Success");
                button_listAlbums_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Failed to delete album/rentals!", "Error");
            }
            

        }
        
        private void button_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox_albumGenre_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
