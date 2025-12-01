Revision
---
- Explain lazy evaluation in LINQ.
    > Lazy evaluation means the query is not executed until the data is accessed.
- Why do you need to convert the outcome of LINQ queries to an array or a list?
    > A lot of LINQ queries return an `IEnumerable`, so converting to an array or list forces the query to execute immediately and store the results in memory.
- How do you convert an `IEnumerable` to an array?
    > `ToArray()`
- How do you convert an IEnumerable to an list?
    > `ToList()`
- How do you filter a sequence of values based on given criteria
    > `Where`
- What does the `Select` method do?
    > Projects/maps each element of a sequence into a new form
- What will be in the array `b` after this code has executed?
    ```csharp
    int[] a = [1, 2, 3];
    int[] b = a.Reverse().ToArray();
    ```csharp
    > [3, 2, 1]
- How can you sort elements of a sequence in ascending order and descending order?
    > `OrderBy` and `OrderByDescending`
- How can you do subsequent ordering of a sequence?
    > `ThenBy` and `ThenByDescending`
- In the following code, in what order will the ages be grouped?
    ```csharp
    IEnumerable<IGrouping<int, Person>> groupByAge = people.GroupBy(person => person.Age);
    ```
    > From youngest to oldest.
- In the following code, how can I print the age groups and the size of each age group? How can I loop through each person in each of the age groups?
    ```csharp
    IEnumerable<IGrouping<int, Person>> groupByAge = people.GroupBy(person => person.Age);
    foreach (var group in groupByAge)
    {
    }
    ```
    >
    ```csharp
    // Iterate over each IGrouping in the collection.
    foreach (var group in groupByAge)
    {
        // Print the key value of the IGrouping.
        Console.WriteLine($"Age group: {group.Key}");
        // How many?
        Console.WriteLine($"Amount: {group.Count()}");
        // Iterate over each value in the IGrouping
        foreach (var person in group)
        {
            // Print the name of each value.
            Console.WriteLine($"{person.Name}");
        }
    }
    ```
- How can I get the unique elements in a sequence?
> `Distinct`
- What do `Intersect` and `Union` do?
    > - `Intersect`: Produces the set intersection of two sequences (shared values) 
    > - `Union`: Produces the set union of two sequences. (unique values)
-  What do `Min`, `Max`, `Sum` and `Count` do?
    > - `Min`: Returns the minimum value in a sequence of values.
    > - `Max`: Returns the maximum value in a sequence of values.
    > - `Sum`: Computes the sum of a sequence of numeric values.
    > - `Count`: Returns a number that represents how many elements in the specified sequence satisfy a condition.
- What will the value of `any` be in the following code?
    ```csharp
    Stack<int> stack = [];
    var any = stack.Any();
    ```
    > `false`
- What will the value of `first` and `last` be in the following code?
    ```csharp
    Stack<int> stack = [];
    stack.Push(1);
    stack.Push(2);
    int first = stack.First();
    int last = stack.Last();
    ```
    > first = 2, last = 1
- What will `values` contain? 
    ```csharp
    int[] values = Enumerable.Range(0, 5).ToArray();
    ```
    > [0, 1 , 2, 3, 4]