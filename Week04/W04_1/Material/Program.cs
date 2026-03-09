static class Program
{
    static void Main()
    {      
        // Convert.ToInt32 is an overloaded method
        // https://learn.microsoft.com/en-us/dotnet/api/system.convert.toint32?view=net-8.0 
        Convert.ToInt32("19");

        // Test SequenceGenerator.Generate
        string seq1 = SequenceGenerator.Generate(1, 10, 2, ", ");
        int seq2 = SequenceGenerator.Generate(1, 4);
        string seq3 = SequenceGenerator.Generate(10);

        // Test Person Constructor
        Person p1 = new("123456", "Bill", 22);
        Person p2 = new("654321", "Lisa");
        Person p3 = new(344543, "Jane");
        Person p4 = new(p1);

        // Will p1's age change when "copy" constructor is used?
        p4.Age++;

        // Student
        Student s1 = new("987654", "Ria", 22, "7878021", 2023);
        // Check what is available s1 (Person members + Student members)

        // Student members are not available to a Person (p1)

        // Student IS a Person
        Person sp = new Student("6352826", "Nick", 24, "01909111", 2021);

        // Doing this will limit what we can access. More on this next week!
        // Console.WriteLine(sp.StudentID); // Error!
    }
}