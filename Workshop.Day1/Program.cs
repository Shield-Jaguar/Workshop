using Workshop.Day1;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<Database>();
var app = builder.Build();

// http://localhost:5118/?postMessage=%23mypost
app.MapGet("/", async (string? postMessage, Database db) =>
{
    if (postMessage == null) return "invalid post";
    var post = Post.CreatePost(postMessage);
    await db.Add(post);
    return "Post " + postMessage + " saved";
});

app.Run();