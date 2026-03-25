


// interfaces
// classes implementing multiple interfaces
// interfaces inheriting from other interfaces
// 

// common interfaces in C# 
// IEnumerable<T>
// ICollection<T>
// IList<T>
// IDisposable

IEnumerable<int> numbers = new List<int> {1, 2, 3, 4, 5};
IList<int> numbersList = new List<int> {1, 2, 3, 4, 5};

numbersList.Add(6);
// numbers.Add(6); // this will not work
// IEnumerable kan alleen maar de collectie lezen maar je weet niet wat de implementatie is.

IEnumerable<int> AllNumbers()
{
    for (int i = int.MinValue; i <= int.MaxValue; i++)
    {
        yield return i;
    }
}

numbers = AllNumbers();



// things de did not cover about interfaces
// default implementations
// static methods
// static properties



// volgende les
// Abstract classes
// abstract methods and properties