using System.Collections.Concurrent;
using AlbumInventory.Protos;

namespace AlbumInventory.Server.Models
{
    public class AlbumStore
    {
        private readonly ConcurrentDictionary<string, Album> _albums = new();

        public bool TryAdd(Album album) => _albums.TryAdd(album.Id, album);

        public bool TryGet(string id, out Album album) => _albums.TryGetValue(id, out album);

        public bool TryUpdate(string id, Album album)
        {
            if (!_albums.ContainsKey(id)) return false;
            _albums[id] = album;
            return true;
        }

        public bool TryRemove(string id, out Album removed) => _albums.TryRemove(id, out removed);

        public IEnumerable<Album> AllAlbums() => _albums.Values.ToList();
    }
}
