static class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "Book": TestBook(); return;
            case "Add": TestAdd(); return;
            case "Find": TestFind(); return;
            case "Edit": TestEdit(); return;
            case "Remove": TestRemove(); return;
            default: throw new ArgumentException();
        }
    }

    public static void TestBook()
    {
        List<Book> books = new()
        {
            new Book(1, "The Great Gatsby"),
            new Book(2, "To Kill a Mockingbird"),
            new Book(3, "1984"),
        };

        foreach (var book in books)
        {
            Console.WriteLine(book.Info());
        }
    }

    public static void TestAdd()
    {
        Console.WriteLine("=== Library 1 ===");
        int size = 3;
        Library library = new(size);

        Console.WriteLine($"Attempt to add book. Succeeded: {library.AddBook(1, "The Great Gatsby")}");
        Console.WriteLine($"Attempt to add book. Succeeded: {library.AddBook(2, "To Kill a Mockingbird")}");
        Console.WriteLine($"Attempt to add book. Succeeded: {library.AddBook(3, "1984")}");
        Console.WriteLine($"Attempt to add book. Succeeded: {library.AddBook(4, "Animal Farm")}");

        Console.WriteLine("\n=== Library 2 ===");
        size = 4;
        library = new(size);

        Console.WriteLine($"Attempt to add book. Succeeded: {library.AddBook(1, "The Great Gatsby")}");
        Console.WriteLine($"Attempt to add book. Succeeded: {library.AddBook(2, "To Kill a Mockingbird")}");
        Console.WriteLine($"Attempt to add book. Succeeded: {library.AddBook(3, "1984")}");
        Console.WriteLine($"Attempt to add book. Succeeded: {library.AddBook(4, "Animal Farm")}");
    }

    public static void TestFind()
    {
        Library library = new(3);

        library.AddBook(1, "The Catcher in the Rye");
        library.AddBook(2, "To Kill a Mockingbird");
        library.AddBook(3, "The Great Gatsby");

        Console.WriteLine("Finding books in the library:");

        int id = 2;
        Book foundBook = library.FindBookByID(id);
        Console.WriteLine($" - Searched for book with ID {id}: " +
            $"{foundBook?.Title}");

        id = 4;
        Book notFoundBook = library.FindBookByID(id);
        Console.WriteLine($" - Searched for book with ID {id}: " +
            $"{notFoundBook?.Title ?? "not found"}");
    }

    public static void TestEdit()
    {
        Library library = new(4);

        library.AddBook(1, "The Catcher in the Rye");
        library.AddBook(2, "To Kill a Mockingbird");
        library.AddBook(2, "To Kill a Mockingbird");
        library.AddBook(3, "The Great Gatsby");

        library.EditBookTitle(2, "To Kill a Mockingbird (Kindle Edition)");

        Console.WriteLine("Current library books after editing:");
        foreach (var book in library.Books)
        {
            Console.WriteLine($" - {book.Info()}");
        }
    }

    public static void TestRemove()
    {
        Library library = new(10);

        library.AddBook(1, "The Catcher in the Rye");
        library.AddBook(2, "To Kill a Mockingbird");
        library.AddBook(3, "The Great Gatsby");
        library.AddBook(4, "Animal Farm");
        library.AddBook(2, "To Kill a Mockingbird");

        library.RemoveBookByTitle("To Kill a Mockingbird");
        library.RemoveBookByTitle("The Great Gatsby");

        Console.WriteLine("Current library books after removing:");
        foreach (var book in library.Books)
        {
            Console.WriteLine($" - {book.Info()}");
        }
    }
}
