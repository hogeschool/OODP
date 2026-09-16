public class Program
{
    static void Main(string[] args)
    {
        HowCompareToWorks();
        SortStudents();
        UsingContains();
        EqualsMethod();
    }

    public static void HowCompareToWorks()
    {
        /*
        A.CompareTo(B)
        <0  : A comes before B  
        0   : A is in the same position as B
        >0  : A comes after B or B is null
        */
        int one = 1;
        int ten = 10;
        int compare1and10 = one.CompareTo(ten); // -1
        int compare1and1 = one.CompareTo(one); // 0
        int compare10and1 = ten.CompareTo(one); // 1
        int compare1andNull = one.CompareTo(null); // 1

        string a = "a";
        string c = "c";
        int compareAandC = a.CompareTo(c); // -1
        int compareAandA = a.CompareTo(a); // 0 
        int compareCandA = c.CompareTo(a); // 1
    }

    public static void SortStudents(){
        List<Student> students = [
            new("Fred", 24, 30),
            new("Albert", 26, 0),
            new("Zach", 20, 10),
            new("Barry", 30, 20),
            new("Albert", 20, 30),
            new("Eva", 25, 100),
            new("Fred", 22, 50),
            new("Albert", 20, 50),
        ];

        students.Sort(); // Exception if you do not implement IComparable
        Console.WriteLine(string.Join("\n", students));
    }
    
    public static void UsingContains()
    {
        List<int> numbers = [2, 4, 1, 7, 5];
        bool contains7 = numbers.Contains(7);

        List<string> names = ["Jane", "Sarah", "Tim"];
        bool containsJane = names.Contains("Jane");

        List<Person> people = [
            new("Bill", 22),
            new("Sarah", 33),
            new("Jake", 44),
            new("Rita", 19)
        ];
        // Will only compare by value if IEquatable is implemented
        // or Equals from the Object class is overridden,
        // otherwise it will compare by reference.
        Console.WriteLine(
            people.Contains(
                new Person("Rita", 19)));
    }

    public static void EqualsMethod()
    {
        Console.WriteLine("\nImplementing IEquatable");

        Person alice1 = new("Alice", 18);
        Person bob = new("Bob", 17);
        Person alice2 = new("Alice", 18);

        Console.WriteLine($"alice1.Equals(bob): {alice1.Equals(bob)}");
        Console.WriteLine($"alice1.Equals(alice2): {alice1.Equals(alice2)}");
        Console.WriteLine($"alice1.Equals(null): {alice1.Equals(null!)}");
        Console.WriteLine($"alice1.Equals(\"string\"): {alice1!.Equals("Alice")}");
    }
}