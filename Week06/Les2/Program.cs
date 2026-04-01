
// Generics

// A really powerful concept.
// But also quite abstract and hard to understand at first.


// Generic types we know already:

List<int> numbers = new List<int>();
List<string> names = new List<string>();
List<double> doubles = new ();
Dictionary<string, int> nameToAge = new Dictionary<string, int>();

// if we didn't have generics, we would have to do something like this:
List<object> objects = new List<object>();
objects.Add(1);
objects.Add("Hello");
