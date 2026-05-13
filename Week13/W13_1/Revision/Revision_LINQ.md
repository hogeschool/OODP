Revision
---
- Explain lazy evaluation with respect to LINQ.
- Why would you convert the outcome of LINQ queries to an array or a list?
- How do you convert an `IEnumerable` to an array?
- How do you convert an `IEnumerable` to a `List`?
- How do you filter a sequence of values based on given criteria?
- What does the `Select` method do?
- What will be in the array `b` after this code has executed?
    ```csharp
    int[] a = [1, 2, 3];
    int[] b = a.Reverse().ToArray();
    ```
- How can you sort elements of a sequence in ascending order and descending order?
- How can you do subsequent ordering of a sequence?
- In the following code, in what order will the ages be grouped?
    ```csharp
    IEnumerable<IGrouping<int, Person>> groupByAge = people.GroupBy(person => person.Age);
    ```
- In the following code, how can I print the age groups and the size of each age group? How can I loop through each person in each of the age groups?
    ```csharp
    IEnumerable<IGrouping<int, Person>> groupByAge = people.GroupBy(person => person.Age);
    foreach (var group in groupByAge)
    {
    }
    ```
- How can I get the unique elements in a sequence?
- What do `Intersect` and `Union` do?
-  What do `Min`, `Max`, `Sum` and `Count` do?
- What will the value of `any` be in the following code?
    ```csharp
    Stack<int> stack = [];
    var any = stack.Any();
    ```
- What will the values of `first` and `last` be in the following code?
    ```csharp
    Stack<int> stack = [];
    stack.Push(1);
    stack.Push(2);
    int first = stack.First();
    int last = stack.Last();
    ```
- What will the values of `firstEven` and `moreThan3` be in the following code?
    ```csharp
    int[] numbers = [1, 3, 5, 7];
    int firstEven = numbers.FirstOrDefault(x => x % 2 == 0);
    int[] moreThan3 = numbers
    .Where(x => x > 3)
    .Take(3)
    .ToArray();
    ```
- What will `values` contain? 
    ```csharp
    int[] values = Enumerable.Range(0, 5).ToArray();
    ```
