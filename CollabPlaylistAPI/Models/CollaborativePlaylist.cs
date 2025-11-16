using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabPlaylistAPI.Models
{
    public class CollaborativePlaylist : Playlist
    {
        // Invite a user to collaborate
        public void InviteCollaborator(int userId)
        {
            if (!CollaboratorIds.Contains(userId))
                CollaboratorIds.Add(userId);
        }

        // Vote for a song
        public void VoteSong(int songId)
        {
            Song song = Songs.FirstOrDefault(s => s.Id == songId);
            if (song != null)
                song.Votes++;
        }
    }
}
