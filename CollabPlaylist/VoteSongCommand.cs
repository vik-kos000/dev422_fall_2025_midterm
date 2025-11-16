using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabPlaylist
{
    public class VoteSongCommand : ICommand
    {
        private CollaborativePlaylist playlist;
        private int songId;

        public VoteSongCommand(CollaborativePlaylist playlist, int songId)
        {
            this.playlist = playlist;
            this.songId = songId;
        }

        public void Execute()
        {
            playlist.VoteSong(songId);
        }
    }
}
