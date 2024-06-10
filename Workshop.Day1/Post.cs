public class Post
{
    internal void CreatePost(Database db, string postmessage)
    {
        if (postmessage.StartsWith("#"))
        {
            db.AddAsTag(postmessage);
        }
        else
        {
            db.Add(postmessage);
        }
    }
}