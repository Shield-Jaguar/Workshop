namespace Workshop.Day1;

public abstract class Post
{
    protected Post(string message, string type)
    {
        Message = message;
        Type = type;
    }
    public string Message { get; }
    
    public string Type { get; }

    public static Post CreatePost(string message) =>
        message switch
        {
            null => throw new ArgumentNullException(nameof(message)),
            ['#', .. var s] => TaggedPost.Create(s),
            _ => SimplePost.Create(message)
        };
}