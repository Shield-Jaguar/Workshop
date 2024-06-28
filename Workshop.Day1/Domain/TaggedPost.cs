using Workshop.Day1;

public class TaggedPost: Post
{
    private TaggedPost(string message, string type) : base(message, type) { }

    public static TaggedPost Create(string message)
    {
        if (!message.StartsWith('#')) throw new InvalidOperationException();
        return new TaggedPost(message, nameof(TaggedPost));
    }
}