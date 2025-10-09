/*
Contents:
- generic classes and methods (W06.2.1T01-08) 
        -> https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics 
- where constraints (W06.2.1T09)        
        -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint
*/

public class Program
{
    static void Main(string[] args)
    {
        GenericsBasics();
        GenericsWhere();
    }
    
    public static void GenericsBasics()
    {
        List<CourseFormFieldText> cffTexts = [
            new("Basic Programming", "Good"),
            new("Basic Programming", "Poor"),
            new("Basic Programming", "Excellent")
        ];
    }
    
    public static void GenericsWhere()
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
}
