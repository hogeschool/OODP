/*
Week 13: Higher-order Methods & Lambda's
    
In C#, a lambda expression is a shorthand syntax for creating an anonymous
method. It allows you to define a block of code that can be passed as an argument to a method or stored in a variable, without having to define a named method separately.

Here's an example of a simple lambda expression: x => x * 2
In this example, x is the input parameter, => is the arrow symbol that separates the input parameter from the expression body, and x * 2 is the body of the expression.

You can think of a lambda expression as a kind of "inline" method definition.
It's not named, but it can be used in the same way as a named method, such as
by passing it as a parameter to another method or assigning it to a delegate variable.

More on Lambda expressions and anonymous functions:
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

A higher-order method is a method that takes one or more methods as arguments
and/or returns a method as its result. Some of the methods in the List class in
C# do fit this definition. For example:
 - The ForEach method takes a method or lambda as an argument and applies it to
   each element in the list.
 - The Find method takes a method or lambda as an argument and returns the
   first element in the list that satisfies the method or lambda.
    
All of these methods take one or more methods as arguments, which makes them higher-order methods.
*/

static class Program
{
    static void Main()
    {
        Basic();
        Advanced();
        Examples();
    }

    public static void Basic()
    {
        // Calling a Higher-order Method with a named method
        RepeatAction(3, RepeatString);

        // with a lambda expression
        RepeatAction(3, (i) => $"Hello, world! (iteration {i + 1})");

        // Array.FindAll with lambda
        string[] teachers = ["Gert-Jan", "Ditmar", "Joana", "Cigdem", "Alessandro", "Kevin", "Jurn"];
        string[] myArr = Array.FindAll(teachers, (e) => e.StartsWith('J'));

        // Print all teacher names starting with a 'J'
        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("{0}", myArr[i]);
        }

        // Or print with Array.ForEach using a lambda expression!
        Array.ForEach(myArr, (e) => Console.WriteLine(e));
    }

/*
Some more advanced examples using the delegate types Action and Func.
 - A Func delegate is a type that represents a method that takes zero or more input parameters and returns a value.
 - An Action delegate is a type that represents a method that takes zero or more input parameters and returns no value.
*/
    public static void Advanced()
    {
        // Calling a Higher Order Method with Func object containing a lambda expression
        Func<int, string> funcRepeatString = (i) => $"Hello, world! (iteration {i + 1})";
        RepeatAction(3, funcRepeatString);

        // With Action object containing a lambda expression
        Action<string> sayIt = (name) => Console.WriteLine($"My name is {name}!");
        SayMyName(3, "James", sayIt);
    }

// Higher Order Method taking a method with an input parameter and that returns a value.
    public static void RepeatAction(int numTimes, Func<int, string> action)
    {
        for (int i = 0; i < numTimes; i++)
        {
            string result = action(i);
            Console.WriteLine(result);
        }
    }

// Higher Order Method taking a method with only an input parameter.
    public static void SayMyName(int numTimes, string name, Action<string> action)
    {
        for (int i = 0; i < numTimes; i++)
        {
            action(name);
        }
    }

//Named method.
    public static string RepeatString(int numRepeats)
    {
        return $"Hello, world! (iteration {numRepeats + 1})";
    }

    public static void Examples()
    {
        List<Car> cars = [new Car("Kia", "Blue"), new Car("Mazda", "Red"), new Car("Volvo", "Black")];
        List<Car> filteredCars = [];

        // LONG
        foreach (Car car in cars)
        {
            if (car.Brand.StartsWith('V'))
            {
                filteredCars.Add(car);
            }
        }
        foreach (Car car in filteredCars)
        {
            Console.WriteLine(car);
        }

        // SHORTER
        filteredCars = FilterCars(cars, e => e.Brand.StartsWith('V'));
        filteredCars.ForEach(car => Console.WriteLine(car));

        // SHORTEST (?)
        cars.FindAll(car => car.Brand.StartsWith('V')).ForEach(car => Console.WriteLine(car));
    }

    public static List<Car> FilterCars(List<Car> cars, Func<Car, bool> action) => cars.FindAll(car => action(car));
}
