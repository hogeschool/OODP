/*
Contents:
 - IComparable (W07.1.1T01)              
        -> https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1
        -> https://learn.microsoft.com/en-us/dotnet/api/system.icomparable
 - IEquatable (W07.1.1T02-03)
        -> https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1
        -> https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals
        -> https://learn.microsoft.com/en-us/dotnet/api/system.object.equals
*/

static class Program
{
    static void Main()
    {
        Compare();
        EqualsMethod();
    }

    public static void Compare()
    {
        Console.WriteLine("\nImplementing IComparable");

        List<Student> students = [
            new() { Name = "Alice", Age = 18, GradeLevel = 12 },
            new() { Name = "Bob", Age = 17, GradeLevel = 11 },
            new() { Name = "Charlie", Age = 18, GradeLevel = 12 },
            new() { Name = "Dave", Age = 16, GradeLevel = 10 }
        ];

        Console.WriteLine("Unsorted list:");
        PrintStudents(students);

        students.Sort();

        Console.WriteLine("\nSorted list:");
        PrintStudents(students);
    }

    private static void PrintStudents(List<Student> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade Level: {student.GradeLevel}");
        }
    }

    public static void EqualsMethod()
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
}