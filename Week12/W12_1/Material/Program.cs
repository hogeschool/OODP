static class Program
{
    // The examples with intArr will also work with lists.
    // You do however need to change ToArray() to ToList().
    static readonly int[] intArr = [12, 1, 3, 2, 6, 3, 2, 4, 9, 10, 7, 1, 5];
    static readonly List<Person> people = [
        new("Clara", 25),
        new("Joan", 25),
        new("Anne", 10),
        new("John", 12),
        new("John", 12),
        new("John", 30),
        new("Jane", 25),
        new("Zara", 2),
        new("Bill", 25),
        new("Will", 20),
    ];

    static void Main()
    {
        /*
            LINQ: Language-Integrated Query
            Allows us to easily perform queries on data.
            https://www.tutorialsteacher.com/linq (English is not great though!!!)
        */
        Filter();
        Map();
        Ordering();
        Grouping();
        SetOperations();
        Aggregation();
        ExaminingElements();
        RangeGeneration();
        QuerySyntax();
        MoreExamples();
    }

    public static void Filter()
    {
        /*
           Where: Filters a sequence of values based on 
           given criteria (defined using a function).

           Like most LINQ queries, this will return an IEnumerable,
           so you need to convert to required data type.

           IEnumerable: will use lazy evaluation, so query will 
           only be executed when data is requested
       */

        // Filter for even numbers IEnumerable<int> lazyEvens
        IEnumerable<int> lazyEvens = intArr.Where(num => num % 2 == 0);

        // Use ToArray() to have results as an array  
        int[] evens = intArr.Where(num => num % 2 == 0).ToArray();

        // To demonstrate lazy evaluation.
        // Notice that the Where query is not
        // actually executed until the foreach loop.
        intArr[0] = 8;

        // 8 2 6 2 4 10
        foreach (var number in lazyEvens)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // 12 2 6 2 4 10
        foreach (var number in evens)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Adults: Joan, Jane, John, Will.
        // ToList() to convert to List .
        List<Person> adults = people
            .Where(person => person.Age >= 18)
            .ToList();
    }

    public static void Map()
    {
        /*
            Select: Projects/maps each element of a sequence 
            into a new form
        */
        // increaseNumbers
        int[] increaseNumbers = intArr
            .Select(number => number + 1)
            .ToArray();

        // Copy numbers 
        int[] copyNumbers = intArr
            .Select(number => number)
            .ToArray();

        /*
            Underscores (_) are a convention to signal that 
            the parameter is not used. It is a temp value, 
            just like in Python.  
            In this case, the _ indicates that each element 
            should be returned as is.
        */
        int[] copyNumbers2 = intArr
            .Select(_ => _)
            .ToArray();

        // Copy people (deep copy)
        List<Person> copyPeople = people
            .Select(person => new Person(person.Name, person.Age))
            .ToList();

        // increaseAges
        List<Person> olderPeople = people
            .Select(person => new Person(person.Name, person.Age + 1))
            .ToList();

        // names
        string[] names = people
            .Select(person => person.Name)
            .ToArray();
    }

    public static void Ordering()
    {
        /*
            Reverse: Inverts the order of the elements in a sequence.
            
            OrderBy: sorts the elements of a sequence in ascending order
            OrderByDescending: sorts the elements of a sequence in descending order
            ThenBy: second level sorting in ascending order
            ThenByDescending: second level sorting in descending order
        */
        // Reverse numbers
        int[] numbersReversed = intArr.Reverse().ToArray();

        // orderedNumbers ascending
        int[] orderedNumbersAsc = intArr.OrderBy(_ => _).ToArray();
        int[] orderedNumberDesc = intArr.OrderByDescending(_ => _).ToArray();

        // orderByName ascending
        List<Person> orderByNameAsc = people.OrderBy(person => person.Name).ToList();

        // orderByAge descending
        List<Person> orderByAgeDesc = people.OrderByDescending(person => person.Age).ToList();

        // order by name ascending then age ascending
        List<Person> orderByNameAndAgeAsc = people
            .OrderBy(person => person.Name)
            .ThenBy(person => person.Age)
            .ToList();

        // order by name ascending then age descending
        List<Person> orderByNameAndAgeDesc = people
            .OrderBy(person => person.Name)
            .ThenByDescending(person => person.Age)
            .ToList();
    }

    public static void Grouping()
    {
        /*
            GroupBy: Groups the elements of a sequence.
            returns an IEnumerable<IGrouping<TKey,TElement>>

            Note: Elements in a grouping are yielded in the order 
            that the elements that produced them appear in source.
        */
        // groupByAge
        IEnumerable<IGrouping<int, Person>> groupByAge = people.GroupBy(person => person.Age);
        PrintGrouping(groupByAge);

        //groupByAgeAsc (OrderBy groupByAge)
        var groupByAgeAsc = groupByAge.OrderBy(grouping => grouping.Key);
        PrintGrouping(groupByAgeAsc);

        // In one query groupByAgeDesc
        IEnumerable<IGrouping<int, Person>> groupByAgeDesc = people
            .OrderByDescending(person => person.Age)
            .GroupBy(person => person.Age);
        PrintGrouping(groupByAgeDesc);
    }

    private static void PrintGrouping(IEnumerable<IGrouping<int, Person>> groupByAge)
    {
        // Iterate over each IGrouping in the collection.
        foreach (IGrouping<int, Person> group in groupByAge)
        {
            // Print the key value of the IGrouping.
            Console.WriteLine(group.Key);
            // How many?
            Console.WriteLine(group.Count());
            // Iterate over each value in the IGrouping
            foreach (Person p in group)
            {
                // Print the name of each value.
                Console.WriteLine("---" + p.Name);
            }
        }
        Console.WriteLine();
    }

    public static void SetOperations()
    {
        /*
            Distinct: Returns distinct/unique elements from a sequence.
            Intersect: Produces the set intersection of two sequences (shared values)
            Union: Produces the set union of two sequences. (unique values)
        */
        // uniqueNumbers
        int[] uniqueNumbers = intArr
            .Distinct()
            .ToArray();

        // uniqueNames
        List<string> uniqueNames = people
            .Select(person => person.Name)
            .Distinct()
            .ToList();

        int[] set1 = [1, 2, 3, 4, 5];
        int[] set2 = [4, 5, 6, 7, 8];
        // Intersection: what arrays have in common {4, 5}
        int[] intersection = set1
            .Intersect(set2)
            .ToArray();
        // Union: all distinct values in both arrays {1, 2, 3, 4, 5, 6, 7, 8}
        int[] union = set1
            .Union(set2)
            .ToArray();
    }

    public static void Aggregation()
    {
        /*
            Min: Returns the minimum value in a sequence of values.
            Max: Returns the maximum value in a sequence of values.
            Sum: Computes the sum of a sequence of numeric values.
        */

        // Min, max and sum of numbers
        int min = intArr.Min();
        int max = intArr.Max();
        int sum = intArr.Sum();

        // CountEvens
        int countEvent = intArr.Count(num => num % 2 == 0);

        // Get maximum age
        int maxAge1 = people.Select(person => person.Age).Max();
        int maxAge2 = people.Max(person => person.Age);
    }

    public static void ExaminingElements()
    {
        /*
            First: Returns the first element of a sequence.
            Last: Returns the last element of a sequence.
            Any: Determines whether a sequence contains any elements.
        */
        int firstEven = intArr
            .Where(num => num % 2 == 0)
            .OrderBy(_ => _)
            .First();
        int lastEven = intArr
            .Where(num => num % 2 == 0)
            .OrderBy(_ => _)
            .Last();

        Queue<string> tasks = [];
        tasks.Enqueue("Study LINQ");
        tasks.Enqueue("Cook dinner");
        tasks.Enqueue("Sleep");

        // Breaks the queue idea, but it works!
        string firstTask = tasks.First();
        string lasTask = tasks.Last();

        while (tasks.Any())
        {
            Console.WriteLine(tasks.Dequeue());
        }
    }

    public static void RangeGeneration()
    {
        /*
            Range: Generates a sequence of 
            integral numbers within a specified range.
            (Like range in Python)
        */

        // values is an array containing the values from 0 to 9.
        // First value is start value, second value is the amount of values
        int[] values = Enumerable.Range(0, 10).ToArray();
    }

    public static void QuerySyntax()
    {
        /*
            Query syntax is similar to SQL (Structured Query Language)
            The LINQ query syntax starts with from keyword and ends 
            with either a Select or Group clause.
        */
        // Method Syntax
        List<string> jNames1 = people
            .Where(person => person.Name.StartsWith("J"))
            .OrderBy(person => person.Name)
            .Select(person => person.Name)
            .ToList();

        // Query Syntax
        List<string> jNames2 = (
            from person in people
            where person.Name.StartsWith("J")
            orderby person.Name
            select person.Name
        ).ToList();
    }

    public static void MoreExamples()
    {
        // unique odds squared descending
        int[] oddsSquared = intArr
            .Where(number => number % 2 == 1)
            .Distinct()
            .Select(num => num * num)
            .OrderByDescending(_ => _)
            .ToArray();

        // namesStartWithJ order by name then by age
        var jNames = people
            .Where(person => person.Name.StartsWith("J"))
            .OrderBy(person => person.Name)
            .ThenBy(person => person.Age)
            .ToList();
    }
}