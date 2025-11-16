using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CollabPlaylist
{
    public class PlaylistService
    {
        private readonly HttpClient httpClient;
        private readonly string baseUrl = "https://localhost:7169/api/playlists"; // change port if your API runs differently

        public PlaylistService()
        {
            httpClient = new HttpClient();
        }

        // GET /api/playlists
        public async Task<List<Playlist>> GetPlaylistsAsync()
        {
            var response = await httpClient.GetAsync(baseUrl);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Playlist>>(json);
        }

        // POST /api/playlists
        public async Task<Playlist> CreatePlaylistAsync(Playlist playlist)
        {
            string json = JsonConvert.SerializeObject(playlist);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(baseUrl, content);
            response.EnsureSuccessStatusCode();

            string resultJson = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Playlist>(resultJson);
        }

        // PUT /api/playlists/{id}/add
        public async Task AddSongAsync(int playlistId, Song song)
        {
            string json = JsonConvert.SerializeObject(song);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PutAsync($"{baseUrl}/{playlistId}/add", content);
            response.EnsureSuccessStatusCode();
        }

        // PUT /api/playlists/{id}/invite
        public async Task InviteCollaboratorAsync(int playlistId, int userId)
        {
            var payload = new { UserId = userId }; // This matches InviteDto
            string json = JsonConvert.SerializeObject(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PutAsync($"{baseUrl}/{playlistId}/invite", content);
            response.EnsureSuccessStatusCode();
        }

        // POST /api/playlists/{id}/vote
        public async Task VoteSongAsync(int playlistId, int songId)
        {
            var payload = new { SongId = songId };
            string json = JsonConvert.SerializeObject(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"{baseUrl}/{playlistId}/vote", content);
            response.EnsureSuccessStatusCode();
        }

        // GET /api/playlists/{id}/rankings
        public async Task<List<Song>> GetRankingsAsync(int playlistId)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/{playlistId}/rankings");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Song>>(json);
        }
    }
}
