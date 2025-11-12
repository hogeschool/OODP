// See the Excel sheet for an overview of the LINQ methods.

// Note: all examples work with both lists and arrays.
// Make sure to use `ToList()` for lists and `ToArray()` for arrays.

static class Program
{
    static void Main()
    {
        WhereExample();
        OrderByExample();
        ReverseExample();
        SetOperationsExample();
        DistinctExample();
        SelectExample();
        QuerySyntaxExample();
        GroupByExample();
        MinMaxExample();
        RangeExample();
        FirstLastExample();
        ThenByExample();
    }

    // Sample data
    public static readonly List<int> IntList = [1, 2, 3, 4, 5, 4, 1, 2, 3];
    public static readonly int[] intArr = [-5, -3, 6, 2, 2, 6, -2];

    // ---------- LINQ Examples ----------

    static void WhereExample()
    {
        Console.WriteLine("=== WHERE ===");
        var filtered = IntList.Where(x => x > 2).ToList();
        Console.WriteLine("Numbers > 2: " + string.Join(", ", filtered));
        Console.WriteLine();
        
        List<Person> people =
        [
            new("Joan", 25),
            new("Jane", 2),
            new("John", 20),
            new("John", 30),
            new("Will", 20),
            new("Jack", 20),
            new("Jill", 26)
        ];
        
        List<Person> peopleOver25 = people
            .Where(p => p.Age > 25)
            .ToList();
        
        Console.WriteLine("People over 25: " + string.Join(", ", peopleOver25));
    }

    static void OrderByExample()
    {
        Console.WriteLine("=== ORDERBY / ORDERBYDESC ===");
        var ordered = IntList.OrderBy(x => x).ToList();
        var orderedDesc = IntList.OrderByDescending(x => x).ToList();
        Console.WriteLine("Ascending: " + string.Join(", ", ordered));
        Console.WriteLine("Descending: " + string.Join(", ", orderedDesc));
        Console.WriteLine();
    }

    static void ReverseExample()
    {
        Console.WriteLine("=== REVERSE ===");
        var reversed = Enumerable.Reverse(IntList).ToList(); // LINQ version
        Console.WriteLine("Reversed (LINQ): " + string.Join(", ", reversed));
        Console.WriteLine();
    }

    static void SetOperationsExample()
    {
        Console.WriteLine("=== INTERSECT / UNION ===");
        List<int> IntList2 = [1, 2, 3, 2, 1, 5, 6];

        var intersection = IntList.Intersect(IntList2).ToList();
        var union = IntList.Union(IntList2).ToList();

        Console.WriteLine("Intersection: " + string.Join(", ", intersection));
        Console.WriteLine("Union: " + string.Join(", ", union));
        Console.WriteLine();
    }

    static void DistinctExample()
    {
        Console.WriteLine("=== DISTINCT ===");

        var positiveAndUnique = IntArr
            .Where(x => x > 0)
            .Distinct()
            .ToArray();
        Console.WriteLine("First positive, then unique: " + string.Join(", ", positiveAndUnique));

        Console.WriteLine();
    }

    static void SelectExample()
    {
        Console.WriteLine("=== SELECT (OBJECTS) ===");

        List<Person> people =
        [
            new("Joan", 25),
            new("Jane", 25),
            new("John", 20),
            new("John", 30),
            new("Will", 20),
            new("Jack", 20)
        ];

        var namesStartWithJo = people
            .Select(p => p.Name)
            .Where(name => name.StartsWith("Jo"))
            .Distinct()
            .ToList();

        Console.WriteLine("Names starting with 'Jo': " + string.Join(", ", namesStartWithJo));
        Console.WriteLine();
    }

    static void QuerySyntaxExample()
    {
        Console.WriteLine("=== QUERY SYNTAX (ALTERNATIVE) ===");

        List<Person> people =
        [
            new("Joan", 25),
            new("Jane", 25),
            new("John", 20),
            new("John", 30),
            new("Will", 20),
            new("Jack", 20)
        ];

        var namesStartWithJo = (
            from person in people
            where person.Name.StartsWith("Jo")
            select person.Name
        ).Distinct().OrderBy(name => name).ToList();

        Console.WriteLine("Query syntax result: " + string.Join(", ", namesStartWithJo));
        Console.WriteLine();
    }

    static void GroupByExample()
    {
        Console.WriteLine("=== GROUPBY ===");

        List<Person> people =
        [
            new("Joan", 25),
            new("Jane", 25),
            new("John", 20),
            new("Will", 20),
            new("Jack", 20),
            new("Anna", 30)
        ];

        var groups = people
            .OrderBy(p => p.Age)
            .GroupBy(p => p.Age);

        foreach (var group in groups)
        {
            Console.WriteLine($"Age {group.Key}:");
            foreach (var person in group)
            {
                Console.WriteLine("  " + person.Name);
            }
        }
        Console.WriteLine();
    }

    static void MinMaxExample()
    {
        Console.WriteLine("=== MIN / MAX ===");
        Console.WriteLine($"Min: {IntList.Min()}, Max: {IntList.Max()}");
        Console.WriteLine();
    }

    static void RangeExample()
    {
        Console.WriteLine("=== ENUMERABLE.RANGE ===");
        var zeroToNine = Enumerable.Range(0, 10).ToArray();
        Console.WriteLine("Range 0–9: " + string.Join(", ", zeroToNine));
        Console.WriteLine();
    }

    static void FirstLastExample()
    {
        Console.WriteLine("=== FIRST / LAST ===");
        Console.WriteLine($"First: {IntList.First()}, Last: {IntList.Last()}");
        Console.WriteLine();
    }

    static void ThenByExample()
    {
        Console.WriteLine("=== ORDERBY + THENBY ===");

        List<Person> people =
        [
            new("John", 30),
            new("John", 20),
            new("Jane", 25),
            new("Jack", 25),
            new("Will", 20)
        ];

        var orderedPeople = people
            .OrderBy(p => p.Age)
            .ThenBy(p => p.Name)
            .ToList();

        foreach (var person in orderedPeople)
        {
            Console.WriteLine($"{person.Name} ({person.Age})");
        }
        Console.WriteLine();
    }
}

class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public override string ToString() => $"{Name} ({Age})";
}