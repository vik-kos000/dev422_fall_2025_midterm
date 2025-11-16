using AlbumInventory.Server.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();
builder.Services.AddSingleton<AlbumInventory.Server.Models.AlbumStore>();

var app = builder.Build();
app.MapGrpcService<AlbumApi>();
app.MapGet("/", () => "AlbumInventory gRPC server is running (HTTP).");
app.Run();
