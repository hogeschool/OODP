class UnderstandingUsing
{
    public static string Path = @"";
    public static string FileName = "MyFile.txt";
    public static string File = Path + FileName;

    public static void Main()
    {
        WriteHello(File); // Works fine
        WriteHello(null); // Gracefully deals with errors
    }

    /*
        In C#, the garbage collector manages the memory used
        in your program. However, there are some types where
        resources are used that are not managed by the garbage 
        collector such as file handlers, network sockets, 
        and database connections. These classes usually implement 
        IDisposable and therefore have a Dispose method to perform 
        cleanup.

        The using statement or declaration can be used to call
        the Dispose method, and it will do so even if there is 
        an exception.

        This is not to be confused with the using directive 
        which imports all the types from a namespace.

        Let us look at an example class that implements IDisposable. 

        A StreamWriter is commonly used for writing text to files.
        https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter.-ctor?view=net-8.0

    */
    public static void WriteHello(string path)
    {
        // A check to avoid some exceptions
        if (!IsValidPath(path))
        {
            return;
        }
        try
        {
            /*
                Notice that if you leave out the using keyword
                then the file will not be written to. This is 
                because the Dispose method triggers the data
                to be written and closes the file properly. 

                Note: The file may still be written to if Flush() 
                is called manually, but Dispose() ensures it happens reliably.
            */
            using StreamWriter writer = new(path, true);
            writer.WriteLine("Hello");
            Console.WriteLine("Wrote to file");
        }
        // Not great practice but done for brevity
        catch (Exception e)
        {
            System.Console.WriteLine("Could not write to file, exception: " + e);
        }
    }

    public static bool IsValidPath(string path)
    {
        /*
            Some checks to avoid some exceptions being thrown. 
            It is not vital to understand all the code in these checks, 
            but it is important to understand that you should always
            try to address potential issues without using exception handling.
        */

        // Avoids ArgumentNullException and ArgumentException 
        if (string.IsNullOrEmpty(path))
        {
            Console.WriteLine("Could not write to file: path cannot be null");
            return false;
        }

        // Avoids DirectoryNotFoundException and some IOExceptions
        string directory = System.IO.Path.GetDirectoryName(path);
        // If only a file name is given, directory will be empty so we must also account for this
        if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
        {
            Console.WriteLine("Could not write to file: directory does not exist");
            return false;
        }

        return true;
    }
}