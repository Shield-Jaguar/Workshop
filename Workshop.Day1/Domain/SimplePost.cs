using Workshop.Day1;

public class SimplePost : Post
{
    private SimplePost(string message, string type) : base(message, type) { }

    public static SimplePost Create(string message) => new(message, nameof(SimplePost));
}
