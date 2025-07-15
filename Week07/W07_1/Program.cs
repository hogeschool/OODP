/*
Contents:
 - where constraints (W10.2.C01)        
        -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint
 - IComparable (W10.2.C02)              
        -> https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1?view=net-7.0
        -> https://learn.microsoft.com/en-us/dotnet/api/system.icomparable?view=net-7.0
 - IEquatable (W10.2.C03-04)
        -> https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=net-7.0
        -> https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals?view=net-7.0#system-iequatable-1-equals(-0)
        -> https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0#system-object-equals(system-object)
 - Operator overloading (W10.2.C05-07)
        -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading
 - OPTIONAL:
      - yield return & IEnumerable (W10.2.C07-08)
            -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/yield
*/

static class Program
{
    static void Main()
    {
        Where();
        Compare();
        EqualsMethod();
        EqualsOperator();
        Yield();
    }

    static void Where()
    {
        Console.WriteLine("\nwhere");

        Space space = new(100);

        Box box1 = new(10, 5);
        Box box2 = new(5, 8);
        Ball ball1 = new(3);
        Ball ball2 = new(5);

        space.Load(box1);
        space.Load(ball1);
        space.Load(box2);
        space.Load(ball2);
    }

    static void Compare()
    {
        Console.WriteLine("\nImplementing IComparable");

        List<Student> students = new()
        {
            new() { Name = "Alice", Age = 18, GradeLevel = 12 },
            new() { Name = "Bob", Age = 17, GradeLevel = 11 },
            new() { Name = "Charlie", Age = 18, GradeLevel = 12 },
            new() { Name = "Dave", Age = 16, GradeLevel = 10 }
        };

        Console.WriteLine("Unsorted list:");
        PrintStudents(students);

        students.Sort();

        Console.WriteLine("\nSorted list:");
        PrintStudents(students);
    }

    static void PrintStudents(List<Student> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade Level: {student.GradeLevel}");
        }
    }

    static void EqualsMethod()
    {
        Console.WriteLine("\nImplementing IEquatable");

        Person person1 = new() { Name = "Alice", Age = 18 };
        Person person2 = new() { Name = "Bob", Age = 17 };
        Person person3 = new() { Name = "Alice", Age = 18 };

        Console.WriteLine($"person1.Equals(person2): {person1.Equals(person2)}");
        Console.WriteLine($"person1.Equals(person3): {person1.Equals(person3)}");
        Console.WriteLine($"person1.Equals(null): {person1.Equals(null)}");
        Console.WriteLine($"person1.Equals(\"string\"): {person1.Equals("string")}");
    }

    static void EqualsOperator()
    {
        Console.WriteLine("\nOperator overloading");
        Person person1 = new() { Name = "Alice", Age = 18 };
        Person person2 = new() { Name = "Bob", Age = 17 };
        Person person3 = new() { Name = "Alice", Age = 18 };
        Person person4 = null;

        Console.WriteLine($"person1 == person2: {person1 == person2}");
        Console.WriteLine($"person1 == person3: {person1 == person3}");
        Console.WriteLine($"person1 == null: {person1 == person4}");
    }

    static void Yield()
    {
        Console.WriteLine("\nYield");

        Console.WriteLine("Even numbers, all generated at once");
        foreach (int x in CombinedEvenNumber(9, true))
            Console.WriteLine(x);
        //An iterator is an object that loops over a container
        Console.WriteLine("Even numbers, generated per method call");
        foreach (int x in CombinedEvenNumber(9, false))
        {
            Console.WriteLine(x);
        }
    }

    public static IEnumerable<int> CombinedEvenNumber(int upto, bool useList)
    {
        if (useList)
        {
            //Advantage: can be iterated over multiple times
            //Disadvantage: can consume a lot of memory
            return EvenNumbers(upto);
        }
        else
        {
            //Advantage: low memory consumption
            //Disadvantage: cannot be iterated over multiple times (need to generate again) 
            return ProduceEvenNumbers(upto);
        }
    }

    //This method will consume a significant amount of memory
    //to store the entire list of even numbers, if 'upto' is large.
    static List<int> EvenNumbers(int upto)
    {
        List<int> result = new();
        for (int i = 0; i <= upto; i += 2)
            result.Add(i);
        return result;
    }

    //This method instead uses a 'yield return', which will generate
    //the next value to be returned on each individual method call.
    //This is also how the 'range' function works in Python.
    static IEnumerable<int> ProduceEvenNumbers(int upto)
    {
        for (int i = 0; i <= upto; i += 2)
        {
            yield return i;
        }
        //You can't have both a return statement and a
        //yield return statement in the same method.
    }
}