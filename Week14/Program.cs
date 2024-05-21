// Note: all examples below work with arrays as well.
// You do need to change ToList to ToArray.

// 14.2 class assignments

int[] intArr = [-5, -3, 6, 2, 2, 6, -2];
List<int> intList = [1, 2, 3, 4, 5, 4, 3, 2, 1];

// Use Where to filter numbers larger than 2
List<int> filtered2 = intArr.Where(x => x > 2).ToList();

// Order a list
List<int> orderedList = intList.OrderBy(_ => _).ToList();
List<int> orderedDescList = intList.OrderByDescending(_ => _).ToList(); // Same but reversed
// Use Sort or OrderBy? Depending on the circumstances, one is faster than the other.
// See: https://stackoverflow.com/questions/1832684/c-sharp-sort-and-orderby-comparison

// Reverse a collection
intList.Reverse();

List<int> intList2 = [1, 2, 3, 2, 1, 5, 6];

List<int> intersection = intList.Intersect(intList2).ToList();
List<int> union = intList.Union(intList2).ToList();

// Use Distinct to keep only the unique elements.
List<int> onlyUniques = intList.Distinct().ToList();


// Now let's chain some LINQ methods.
List<int> onlyPositiveAndUnique = intList
    .Distinct()
    .Where(x => x > 0)
    .ToList();

// Use Distinct to keep only the unique elements
// and use Select to make them positive.
// Note that the order of Distinct and Where matters
// Think -- why is this?
int[] uniquesAndPositive = intArr
    .Distinct()
    .Select(x => Math.Abs(x))
    .ToArray();

// Use Select to get all unique names that start with "Jo"
List<Person> people = [
    new Person("Joan", 25),
    new Person("Jane", 25),
    new Person("John", 20),
    new Person("John", 30),
    new Person("Will", 20),
    new Person("Jack", 20),
];

List<string> namesStartWithJo = people
    .Select(person => person.Name)
    .Where(name => name.StartsWith("Jo"))
    .Distinct()
    .ToList();

// An alternative is to use keywords:
List<string> namesStartWithJoAlt = (
    from person in people
    where person.Name.StartsWith("Jo")
    select person.Name
).Distinct().ToList();

// Same as the previous two queries, but also order them by name in ascending order
List<string> namesStartWithJoAsc = people
    .Select(person => person.Name)
    .Where(name => name.StartsWith("Jo"))
    .Distinct()
    .OrderBy(_ => _) // Underscores are a convention to signal that the parameter is not used
    .ToList();

// Same, but order them in descending order
List<string> namesStartWithJoDesc = people
    .Select(person => person.Name)
    .Where(name => name.StartsWith("Jo"))
    .Distinct()
    .OrderByDescending(_ => _)
    .ToList();

// Use GroupBy to print all people by age group
foreach (var group in people
    .OrderBy(person => person.Age)
    .GroupBy(person => person.Age))
{
    Console.WriteLine(group.Key);
    foreach (var person in group)
    {
        Console.WriteLine(person.Name);
    }
}

// 14.2 homework assignments

// Find the minimum and maximum in a collection
int min = intList.Min();
int max = intList.Max();

// 15.2 class assignments

// Similar to Python's `range` method
int[] zero_to_nine = Enumerable.Range(0, 10).ToArray();
// For the transpose assignment: how could this help you?

// Speaks for itself
int first = intList.First();
int last  = intList.Last();

// Use OrderBy and ThenBy to sort based on multiple criteria.
List<Person> orderedPeople = people
    .OrderBy(person => person.Age)
    .ThenBy(person => person.Name)
    .ToList();

// This also works for Stacks!
Queue<Person> queue = new(people);
while (queue.Any()) // Same as queue.Count > 0
{
    Person next = queue.Dequeue();
    Console.WriteLine($"Helping {next.Name}...");
}
