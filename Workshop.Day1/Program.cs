var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// http://localhost:5118/?postMessage=%23mypost
app.MapGet("/", (string? postMessage) =>
{
    if (postMessage == null) return "invalid post";
    var post = new Post();
    var database = new Database();
    post.CreatePost(database, postMessage);
    return "Post " + postMessage + " saved";
});

app.Run();