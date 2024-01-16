public class Author
{
    public string Name;
    public List<string> PublishedBooks = new();

    public Author(string name)
    {
        Name = name;
        //Alternatively, PublishedBooks can be initialized in the constructor.
        //PublishedBooks = new();
    }

    public void PublishBook(string bookName) => PublishedBooks.Add(bookName);

    public string Info()
    {
        string pubBooks = $"{Name} has published the following books:";
        foreach (string book in PublishedBooks)
            pubBooks += $" - {book}\n";
        return pubBooks;
    }
}