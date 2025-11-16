using Grpc.Core;
using AlbumInventory.Protos;
using AlbumInventory.Server.Models;
using System.Collections.Concurrent;

namespace AlbumInventory.Server.Services
{
    public class AlbumApi : AlbumService.AlbumServiceBase
    {
        private readonly AlbumStore _store;
        private static readonly ConcurrentDictionary<Guid, IServerStreamWriter<Album>> _subscribers = new();

        public AlbumApi(AlbumStore store)
        {
            _store = store;
        }

        public override Task<AddAlbumResponse> AddAlbum(AddAlbumRequest request, ServerCallContext context)
        {
            var album = request.Album;
            if (string.IsNullOrEmpty(album.Id)) album.Id = Guid.NewGuid().ToString();

            if (!_store.TryAdd(album))
                throw new RpcException(new Status(StatusCode.AlreadyExists, $"Album {album.Id} already exists."));

            _ = BroadcastAlbumAsync(album);
            return Task.FromResult(new AddAlbumResponse { Album = album });
        }

        public override Task<GetAlbumResponse> GetAlbum(GetAlbumRequest request, ServerCallContext context)
        {
            if (_store.TryGet(request.Id, out var album))
                return Task.FromResult(new GetAlbumResponse { Album = album });

            throw new RpcException(new Status(StatusCode.NotFound, "Album not found."));
        }

        public override Task<UpdateAlbumResponse> UpdateAlbum(UpdateAlbumRequest request, ServerCallContext context)
        {
            var album = request.Album;
            if (!_store.TryUpdate(album.Id, album))
                throw new RpcException(new Status(StatusCode.NotFound, "Album not found."));

            _ = BroadcastAlbumAsync(album);
            return Task.FromResult(new UpdateAlbumResponse { Album = album });
        }

        public override Task<DeleteAlbumResponse> DeleteAlbum(DeleteAlbumRequest request, ServerCallContext context)
        {
            if (!_store.TryRemove(request.Id, out var removed))
                throw new RpcException(new Status(StatusCode.NotFound, "Album not found."));

            var tombstone = new Album
            {
                Id = removed.Id,
                Title = removed.Title,
                Artist = removed.Artist,
                Genre = removed.Genre,
                Year = removed.Year,
                Available = false
            };
            _ = BroadcastAlbumAsync(tombstone);
            return Task.FromResult(new DeleteAlbumResponse { Id = removed.Id });
        }

        public override async Task ListAlbums(ListAlbumsRequest request, IServerStreamWriter<Album> responseStream, ServerCallContext context)
        {
            foreach (var album in _store.AllAlbums())
            {
                await responseStream.WriteAsync(album);
            }
        }

        public override async Task AlbumUpdates(IAsyncStreamReader<Album> requestStream, IServerStreamWriter<Album> responseStream, ServerCallContext context)
        {
            var id = Guid.NewGuid();
            _subscribers[id] = responseStream;

            try
            {
                var readTask = Task.Run(async () =>
                {
                    await foreach (var incoming in requestStream.ReadAllAsync(context.CancellationToken))
                    {
                        _ = BroadcastAlbumAsync(incoming);
                    }
                }, context.CancellationToken);

                await readTask;
            }
            catch (OperationCanceledException) { }
            finally
            {
                _subscribers.TryRemove(id, out _);
            }
        }

        private static async Task BroadcastAlbumAsync(Album album)
        {
            var failed = new List<Guid>();
            foreach (var kv in _subscribers)
            {
                try
                {
                    await kv.Value.WriteAsync(album);
                }
                catch
                {
                    failed.Add(kv.Key);
                }
            }
            foreach (var f in failed) _subscribers.TryRemove(f, out _);
        }
    }
}
