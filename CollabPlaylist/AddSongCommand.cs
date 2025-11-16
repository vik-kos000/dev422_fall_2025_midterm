using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabPlaylist
{
    public class AddSongCommand : ICommand
    {
        private Playlist playlist;
        private Song song;

        public AddSongCommand(Playlist playlist, Song song)
        {
            this.playlist = playlist;
            this.song = song;
        }

        public void Execute()
        {
            playlist.AddSong(song);
        }
    }
}
