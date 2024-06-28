using Workshop.Day1;
using Workshop.Day1.A;
using Workshop.Day1.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDatabase, Database>();


var app = builder.Build();

// http://localhost:5118/?postMessage=%23mypost
app.MapGet("/", async (string? postMessage, IDatabase db) =>
{
    if (postMessage == null) return "invalid post";
    var post = Post.CreatePost(postMessage);
    await db.Add(post);
    return "Post " + postMessage + " saved";
});

app.Run();