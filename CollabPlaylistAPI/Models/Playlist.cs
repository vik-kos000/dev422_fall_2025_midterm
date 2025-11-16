using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabPlaylistAPI.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; } // user ID
        public bool IsCollaborative { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<int> CollaboratorIds { get; set; } = new List<int>();

        // Add a song to the playlist
        public virtual void AddSong(Song song)
        {
            Songs.Add(song);
        }
    }
}
