using Microsoft.AspNetCore.Mvc;
using CollabPlaylistAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace CollabPlaylistAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaylistsController : ControllerBase
    {
        // In-memory storage for playlists and auto-increment IDs
        private static List<Playlist> playlists = new List<Playlist>();
        private static int nextPlaylistId = 1;
        private static int nextSongId = 1;

        // GET /api/playlists
        [HttpGet]
        public IActionResult GetAllPlaylists()
        {
            return Ok(playlists);
        }

        // POST /api/playlists
        [HttpPost]
        public IActionResult CreatePlaylist([FromBody] Playlist playlist)
        {
            playlist.Id = nextPlaylistId++;
            if (playlist.Songs == null)
                playlist.Songs = new List<Song>();

            // If playlist is collaborative, store as CollaborativePlaylist
            if (playlist.IsCollaborative)
            {
                var collab = new CollaborativePlaylist
                {
                    Id = playlist.Id,
                    Name = playlist.Name,
                    CreatedBy = playlist.CreatedBy,
                    IsCollaborative = playlist.IsCollaborative,
                    Songs = playlist.Songs
                };
                playlists.Add(collab);
            }
            else
            {
                playlists.Add(playlist);
            }

            return Ok(playlist);
        }

        // PUT /api/playlists/{id}/add
        [HttpPut("{id}/add")]
        public IActionResult AddSong(int id, [FromBody] Song song)
        {
            var playlist = playlists.FirstOrDefault(p => p.Id == id);
            if (playlist == null) return NotFound();

            song.Id = nextSongId++;
            playlist.Songs.Add(song);
            return Ok();
        }

        // PUT /api/playlists/{id}/invite
        [HttpPut("{id}/invite")]
        public IActionResult InviteCollaborator(int id, [FromBody] InviteDto payload)
        {
            var playlist = playlists.FirstOrDefault(p => p.Id == id);
            if (playlist == null) return NotFound();
            if (!playlist.IsCollaborative) return BadRequest("Playlist is not collaborative.");

            if (!playlist.CollaboratorIds.Contains(payload.UserId))
                playlist.CollaboratorIds.Add(payload.UserId);

            return Ok();
        }

        // POST /api/playlists/{id}/vote
        [HttpPost("{id}/vote")]
        public IActionResult VoteSong(int id, [FromBody] VoteDto payload)
        {
            var playlist = playlists.FirstOrDefault(p => p.Id == id) as CollaborativePlaylist;
            if (playlist == null) return NotFound();

            var song = playlist.Songs.FirstOrDefault(s => s.Id == payload.SongId);
            if (song != null) song.Votes++;

            return Ok();
        }

        // GET /api/playlists/{id}/rankings
        [HttpGet("{id}/rankings")]
        public IActionResult GetRankings(int id)
        {
            var playlist = playlists.FirstOrDefault(p => p.Id == id);
            if (playlist == null) return NotFound();

            var rankedSongs = playlist.Songs.OrderByDescending(s => s.Votes).ToList();
            return Ok(rankedSongs);
        }
    }
}
