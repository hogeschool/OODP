/*
    Contents:
    * PART 1: methods
    * parameters (W02.1.C01)
    * void methods (W02.1.C01)
    * non-void methods (W02.1.C02 & 04)
    * methods calling other methods (W02.1.C03)
    * expression body definition (W02.1.C03)
    * code paths (W02.1.C05)
    * 
    * PART 2: classes
    * instantiation (W02.1.C06)
    * fields (W02.1.C07)
    * constructors (W02.1.C07)
    * this (W02.1.C08)
    * methods
*/

public class Program
{
    public static void Main()
    {
        //In C#, methods need to have their return type specified.
        //Even if they return nothing, they need
        //to specify this with the 'void' keyword.

        //void method
        Greet(); //No parameters
        WishStudentsWell("fine"); //One parameter

        //Non-void methods return a value of the specified type.
        //In this case it is a string.
        Console.WriteLine("This lesson's topics:");
        string topics = WhatIsThisLessonAbout();
        Console.WriteLine(topics);

        //Like in Python, methods can have reference-typed parameters
        //and return reference-typed parameters as well.
        Console.WriteLine("Let's take attendance then.");
        List<string> studentList = new() {
            "Mary Booai",
            "Donald Chase",
            "Franklin Wayne",
            "Cynthia Noland",
            "Wayne Parker",
            "Cameron Phillips",
            "John Reese",
        };
        Console.WriteLine(CheckPresence(studentList, 7));

        //Methods calling other methods.
        //This works the same as in Python.
        LessonIntroduction();

        LessonAboutClasses();
    }

    public static void Greet()
    {
        Console.WriteLine("Hello, students!");
    }

    public static void WishStudentsWell(string status)
    {
        Console.WriteLine($"I hope you all are doing {status} today.");
    }

    public static void LessonIntroduction()
    {
        LetsStart();

        bool areStudentsReady;
        do
        {
            Console.WriteLine("Are you guys ready?");
            areStudentsReady = AreReady();
            Console.WriteLine(areStudentsReady ? "Yes! :D" : "No. :(");
        } while (!areStudentsReady);
    }

    public static string WhatIsThisLessonAbout()
    {
        List<string> topicList = new() { "methods", "basic classes" };
        string topics = "";
        for (int i = 0; i < topicList.Count; i++)
        {
            topics += $"- {topicList[i]}\n";
        }
        return topics;
    }

    //Expression body definition
    public static void LetsStart() => Console.WriteLine("Let's get started!");

    public static bool AreReady()
    {
        Random rand = new();
        return rand.Next(0, 2) == 1;
    }

    public static string CheckPresence(List<string> students, int expectedCount)
    {
        if (students.Count == expectedCount)
            return "Everyone is here!";
        if (students.Count < expectedCount)
            return "Who is missing?";
        //If the next line is commented out, there will be an error:
        //"not all code paths return a value"
        return "Who infiltrated our class?!";
    }

    public static void LessonAboutClasses()
    {
        //Creating a class object is the same as creating
        //a built-in class object like List or Random.
        //There's multiple equivalent ways to create an object:
        Course course1 = new Course("Introduction to programming", 10);
        var course2 = new Course("Intermediate programming", 15);
        Course course3 = new("Advanced programming", 20);

        Console.WriteLine("\n===Accessing the objects' members===");

        Console.WriteLine("Course 1");
        Console.WriteLine(" - Name: " + course1.Name);
        Console.WriteLine(" - Credits: " + course1.Credits);
        Console.WriteLine(" - Info: " + course1.Info());

        Console.WriteLine("Course 2");
        Console.WriteLine(" - Name: " + course2.Name);
        Console.WriteLine(" - Credits: " + course2.Credits);
        Console.WriteLine(" - Info: " + course2.Info());

        Console.WriteLine("Course 3");
        Console.WriteLine(" - Name: " + course3.Name);
        Console.WriteLine(" - Credits: " + course3.Credits);
        Console.WriteLine(" - Info: " + course3.Info());
    }
}
