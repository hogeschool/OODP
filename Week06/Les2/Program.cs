
// Generics

// A really powerful concept.
// But also quite abstract and hard to understand at first.


// Generic types we know already:

using System.Numerics;

List<int> numbers = new List<int>();
List<string> names = new List<string>();
List<double> doubles = new ();
Dictionary<string, int> nameToAge = new Dictionary<string, int>();

// if we didn't have generics, we would have to do something like this:
List<object> objects = new List<object>();
objects.Add(1);
<<<<<<< Updated upstream
objects.Add("Hello");
=======
objects.Add(2);

int sum = 0;
foreach (object obj in objects)
{
    if (obj is int number)
    {
        sum += number;
    }
}

objects.Add("Hello"); // this will compile, but will cause a runtime error when we try to cast it to an int

// We could also have specialized classes for each type we want to use:
// IntList
// StringList

// But the framework would not have a buildin list for every type.
// Especially for our own custom types, we would have to create a new list class for each type we want to use.


// let start with creating our own generic methods

T GetLastElement<T>(List<T> list)
{
    return list[list.Count - 1];
}

List<string> namesList = new List<string> {"Alice", "Bob", "Charlie"};
string lastName = GetLastElement(namesList);

List<int> numbersList = new List<int> {1, 2, 3, 4, 5};
int lastNumber = GetLastElement(numbersList);

// without Generics, we would have to create a separate method for each type we want to use:
string GetLastStringElement(List<string> list)
{
    return list[list.Count - 1];
}

int GetLastIntElement(List<int> list)
{
    return list[list.Count - 1];
}

// multiple generic parameters
(T2, T1) Swap<T1, T2>(T1 item1, T2 item2)
{
    return (item2, item1);
}

// Keep in mind that it you can make programs really type save
// Because it is generic you know inside the method nothing about the specific type.

// If you want to do things you need to add constraints to the generic type parameters:

int SumInts<T>(T a, T b)
{
    // return a + b; // this will not compile because we don't know if T is an int or not
    if (typeof(T) == typeof(int))
    {
        return (int)(object)a + (int)(object)b;
    }
    else
    {
        throw new InvalidOperationException("T must be int");
    }
}

T Sum<T>(T a, T b) where T : INumber<T>
{
    return a + b;
}

T CreateObject<T>() where T : new()
{
    return default(T);
}
 
CreateObject<EmailValidator>();

bool useValidalidators(IEnumerable<IStringValidator> values)
{
    return values.FirstOrDefault().IsValid("");
}

useValidalidators(new List<PasswordValidator>());
>>>>>>> Stashed changes
