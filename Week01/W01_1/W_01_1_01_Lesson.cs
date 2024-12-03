/*
    Note that in this week we will not have the Main method or methods,
    It is just organized this way so it is easier for you to read
    The order of the methods is the order the lesson should be given

    Contents:
    * Variables
    * Operators
    * Comments
    * Output
    * String Concatenation
    * Input
    * Conversion From String
    * Conversion Double Int
    * Conversion Int Double
    * Input ReadKey
    * Be Careful With Read (optional)
    * Types of errors - compiler errors, warnings, run time errors, logical errors

    Class Exercises: W01.11T01 - 03
*/
static class W_01_1_01_Lesson
{
    public static void Variables()
    {
        //sizeof(int) if you are interested -> answer is in bytes
        string surname = "Smith"; //NA
        char initial; //16 bit
        int age = 24; //32 bits
        double height = 165.3; //64 bits
        bool male = true; //8 bits

        // Error initial has not been assigned
        // char initialCopy = initial;
        initial = 'J';
        age = 25;

        var message = "Hello";
        // Advise to avoid var in the beginning
        // Error must use var in one line
        // var city;
        // city = "Rotterdam";

        string fName = "Tim", mName = "van de", lName = "Berg";
    }

    public static void Operators()
    {
        int num1 = 10;
        int num2 = 4;

        int sum = num1 + num2;
        int diff = num1 - num2;
        int mul = num1 * num2;
        // If you divide an integer by an integer then the result is an integer with the decimal part is truncated
        int div = num1 / num2;
        int mod1 = num1 % num2;

        double num3 = 10.0;
        // If there is a double in the expression, the result will be a double
        double divDouble = num3 / num2;
        double myCalculation = 1 + 10 / 4 + 1.5;

        //Shortcuts
        num1 = num1 + 1;
        num1++;
        ++num1;
        int increase1 = num1++;
        int increase2 = ++num1;

        num2 = num2 - 1;
        num2--;
        --num2;
        int decrease1 = num1--;
        int decrease2 = --num1;

        num1 = num1 + 2;
        num1 += 2;
        // -= /= *=
    }

    public static void Comments()
    {
        // This is a comment
        /* 
            This 
            is 
            a 
            multiline 
            comment
        */
    }

    public static void Output()
    {
        Console.WriteLine("Hello, world!");

        Console.Write("Why do Java programmers ");
        Console.Write("have to ");
        Console.WriteLine("wear glasses?");
        Console.WriteLine("Because they don't C#");
    }

    public static void StringConcatenation()
    {
        string surname = "Smith";
        char initial = 'J';
        int age = 24;
        double height = 165.3;
        bool male = false;

        age = 25;

        string information = "Name: " + initial + ", " + surname + "\nAge: " + age +
                             "\nHeight: " + height + "\nMale?: " + male;
        //need to turn on autocomplete in IDE
        string informationInterpolated = $"Name: {initial}, {surname}\nAge: {age}" +
                                         $"\nHeight: {height}\nMale?: {male}";
        Console.WriteLine(information);
        Console.WriteLine(informationInterpolated);
    }

    public static void Input()
    {
        Console.WriteLine("What is your favorite quote?");
        // Explain warning: There is a chance that null (absence of a string) is stored
        // Will learn about null later in the course
        string quote = Console.ReadLine();
        Console.WriteLine($"{quote}\nThat is a nice quote!");
    }

    public static void ConversionFromString()
    {
        string initialStr = "S";
        string ageStr = "24";
        string heightStr = "165.3";

        /*
            Explain that ToChar, ToInt32 and ToDouble are methods (aka functions)
            Introduction to C# documentation
            https://learn.microsoft.com/en-us/dotnet/api/system.convert?view=net-6.0
        */
        char initial = Convert.ToChar(initialStr);
        int age = Convert.ToInt32(ageStr);
        // Depending on locale settings you may need to enter a , or a .
        double height = Convert.ToDouble(heightStr);

        /*
            Show that if you enter a value that cannot be converted 
            you get an exception. Explain exceptions. From Microsoft:
            "Exceptions in C# provide a structured, uniform, and type-safe way of handling both 
            system level and application-level error conditions."            
            For now, in exercises they can assume input will be valid.
            Next lesson we will look at data validation. Later on in the course they will
            learn more about exceptions.
        */
    }

    public static void ConversionIntDouble()
    {
        // an int (32 bit) can fit in a double (64 bit) without data loss
        int myInt = 100;
        double convertIntToDouble = myInt;
    }

    public static void ConversionDoubleInt()
    {
        /* 
            When converting from double to int the decimal part 
            is rounded towards zero to the nearest integral value
            (so effectively it is truncated)
        */
        double aDouble = 9.18;
        int aDoubleToInt = (int)aDouble;
        double bDouble = 99.999;
        int bDoubleToInt = (int)bDouble;
        double cDouble = -8.63;
        int cDoubleToInt = (int)cDouble;

        // Usually, if the double does fit inside an int a certain value is returned
        // No need to cover but FYI: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/checked-and-unchecked
        double dDouble = int.MaxValue + 1.0;
        int dDoubleToInt = (int)dDouble;
        double eDouble = int.MaxValue + 100.0;
        int eDoubleToInt = (int)eDouble;

        // Exception
        // int tryConvert = Convert.ToInt32(dDouble);
    }

    // Ensure to tell the students that this will not work in CodeGrade
    public static void InputReadKey()
    {
        Console.WriteLine("What is your favorite letter?");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine($"{letter} is a nice letter!");
    }

    public static void Errors()
    {
        /* 
            Compiler Error - error corresponding to syntax or semantics

            No need to compile to see errors - 
            VS Code uses built in analyzers to identify compiler errors as you type 
            Identified by a red "squiggle" underscore. Hover over it for additional details.
            Also listed in "Problems" tab (click to go to error)
            Can use filter to see only errors
            
            Read what the compiler says. Then, based on that, examine your program to determine what the problem is.

            For more information on the error look the error code up here:
            https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/
        */
        // int x = 5 // Syntax error: missing semicolon
        // int x = 2; // Semantics error: Duplicate variables


        /*
            Warning - Code will still compile (and therefore run) but there may there may be mistakes

            For more information on the error look the error code up here:
            https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/
        */
        int age = 5; // warning
        string quote = Console.ReadLine(); // nullable warning

        /*
            Runtime errors - occur if an issue is encountered while the program is running

            For more information on the error look the Exception name up here:
            https://learn.microsoft.com/en-us/dotnet/api/system?view=net-6.0
        */
        string greeting = "hello";
        int num = Convert.ToInt32(greeting); // Exception has occurred: CLR/System.FormatException

        /*
            Logical errors - No error or warning is given, but the code does not behave as you intend it to

            These errors can be identified when testing your code.

            To solve these errors, read and debug your code.
        */
        int xPosition = 0;
        int moveRight = xPosition - 1;

        int yPosition = 0;
        int moveUp = yPosition++;
    }

    // Leave this out if you like, a little confusing perhaps?
    public static void BeCarefulWithRead()
    {
        Console.WriteLine("What is your favorite letter?");
        //letter is an int, not a char :(
        int letter = Console.Read();
        Console.WriteLine($"The letter {letter} is a nice letter");

        Console.WriteLine("What is your second favorite letter?");
        // letter2 will be the enter character
        int letter2 = Console.Read();
        Console.WriteLine($"The letter {letter2} is also a nice letter");
    }

    /**********************************************
    *               W01.1.1T01 - 03               *
    ***********************************************/
}
