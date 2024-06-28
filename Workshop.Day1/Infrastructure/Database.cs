using Workshop.Day1.A;

namespace Workshop.Day1.Infrastructure;

public class Database : IDatabase
{
    public async Task Add(Post post)
    {
        var currentDirectory = Environment.CurrentDirectory;
        await File.AppendAllTextAsync(currentDirectory + $"/{post.Type}.txt", post.Message);
    }
}