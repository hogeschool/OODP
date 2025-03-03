class Author
{
    public string Name;
    public List<string> PublishedBooks = []; // [] is the same as new() or new List<string>()

    public Author(string name)
    {
        Name = name;
        //Alternatively, PublishedBooks can be initialized in the constructor.
        //PublishedBooks = [];
    }

    public void PublishBook(string bookName) => PublishedBooks.Add(bookName);

    public string Info()
    {
        string pubBooks = $"{Name} has published the following books:";
        foreach (string book in PublishedBooks)
        {
            pubBooks += $" - {book}\n";
        }
        return pubBooks;
    }
}
