namespace Workshop.Day1;

public class Database
{
    public async Task Add(Post post)
    {
        var currentDirectory = Environment.CurrentDirectory;
        await File.AppendAllTextAsync(currentDirectory + $"/{post.Type}.txt", post.Message);
    }
}