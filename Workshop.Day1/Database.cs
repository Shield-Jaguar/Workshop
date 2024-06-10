class Database
{
    public void AddAsTag(string postmessage)
    {
        var currentDirectory = Environment.CurrentDirectory;
        File.AppendAllText(currentDirectory + "/Tag.txt", postmessage);
    }

    public void Add(string postmessage)
    {
        var currentDirectory = Environment.CurrentDirectory;
        File.AppendAllText(currentDirectory + "/NoTag.txt", postmessage);
    }
}