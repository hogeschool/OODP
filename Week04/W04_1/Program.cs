/*
    Contents:
    * PART 1: reading from & writing to files
    *  - reading (W04.1.C01)
    *  - writing (W04.1.C02)
    * PART 2: JSON
    *  - reading & writing (W04.1.C03-05)
    * PART 3: exception handling
    *  - generic (W04.1.C06)
    *  - specific (W04.1.C07)
    *  - 'finally' block (W04.1.C08)
*/

static class Program
{
    public static void Main()
    {
        //Part 1
        ReadingWriting();

        //Part 2
        Console.WriteLine("\nFor JSON file handling, " +
            "see the Descriptions of the assignments. " +
            "This has example code that you can use.");

        //Part 3
        Console.WriteLine("\nTons of things can go wrong in the code of Part 1.");
        Console.WriteLine("Let us try to catch these, shall we?");
        GenericExceptionHandling();
        SpecificExceptionHandling();
    }

    public static void ReadingWriting()
    {
        string fileName = "people.csv";
        string contents = ReadCSVFileBasic(fileName);
        Console.WriteLine("Printing CSV file contents...");
        Console.WriteLine(contents);

        Console.WriteLine("Please enter a name:");
        string? name = Console.ReadLine();
        Console.WriteLine("Please enter an age:");
        int age = Convert.ToInt32(Console.ReadLine());
        WriteCSVFileBasic(fileName, name, age);
    }

    public static string ReadCSVFileBasic(string csvFileName)
    {
        Console.WriteLine("CSV contents:");
        StreamReader reader = new(csvFileName);
        string contents = reader.ReadToEnd();
        reader.Close();
        return contents;
    }

    public static void WriteCSVFileBasic(string csvFileName, string name, int age)
    {
        StreamWriter writer = new(csvFileName, true);
        writer.WriteLine($"{name},{age}");
        writer.Close();
    }

    public static void GenericExceptionHandling()
    {
        string fileName = "people.csv";
        string contents = ReadCSVFileBetter(fileName);
        Console.WriteLine("Printing CSV file contents...");
        Console.WriteLine(contents);

        Console.WriteLine("Please enter a name:");
        string? name = Console.ReadLine();

        int age = -1;
        bool success = false;
        do
        {
            Console.WriteLine("Please enter an age:");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                success = true;
            }
            //Catches any type of exception.
            catch
            {
                Console.WriteLine("Invalid age; please enter a number.");
            }
        } while (!success);
        WriteCSVFileBetter(fileName, name, age);
    }

    public static void SpecificExceptionHandling()
    {
        string fileName = "people.csv";
        string contents = ReadCSVFileBetter(fileName);
        Console.WriteLine("Printing CSV file contents...");
        Console.WriteLine(contents);

        Console.WriteLine("Please enter a name:");
        string? name = Console.ReadLine();

        int age = -1;
        bool success = false;
        do
        {
            Console.WriteLine("Please enter an age:");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                success = true;
            }
            //Catches a specific type of exception.
            //Multiple catch blocks may be used.
            catch (FormatException)
            {
                Console.WriteLine("Invalid age; please enter a number.");
            }
        } while (!success);
        WriteCSVFileBetter(fileName, name, age);
    }

    public static string ReadCSVFileBetter(string fileName)
    {
        StreamReader? reader = null;
        try
        {
            reader = new StreamReader(fileName);
            return reader.ReadToEnd();
        }
        //Catches any exception: file does not exist,
        //file is used by another process, etc.
        catch (Exception ex)
        {
            Console.WriteLine("Error reading from CSV file: " + ex.Message);
            return "";
        }
        finally //Executed whether there was an exception or not
        {
            reader?.Close();
            //This is the same as:
            //if (file != null)
            //{
            //    file.Close();
            //}
        }
    }

    public static void WriteCSVFileBetter(string csvFileName, string name, int age)
    {
        StreamWriter? writer = null;
        try
        {
            //true: append; false: overwrite
            writer = new StreamWriter(csvFileName, true);
            writer.WriteLine($"{name},{age}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to CSV file: " + ex.Message);
        }
        finally
        {
            writer?.Close();
        }
    }
}
