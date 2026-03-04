# Revision solutions

## static
- What is a `static` field?
  > A static field is a variable that belongs to the class itself rather than to any specific instance and is shared across all instances of the class. You do not need to create an instance of the class to be able to access the field.
- What is a `static` method?
  > A static method is a method that belongs to the class and can be called without creating an instance of the class.
- What is a `static` constructor? When does it run and how many times does it run?
  > A static constructor is a special constructor that initializes static members of the class and runs once before the class is first used.
- What is a `static` class?
  > A static class is a class that cannot be instantiated (or inherited) and can only contain static members.
- Why would you use a `static` class?
  > You would use a static class when you want to group related static methods and fields together without needing to create an instance of the class.

## const and readonly
- What does `const` mean?
  > The const keyword defines a constant value that is known at compile time, it must be assigned at the declaration and cannot be changed after it is assigned.
- What is wrong with the following code? It should define PI which will not change in our program.

  `public static const double PI;`
  > static is not valid or necessary here since const is implicitly static. The value is not assigned at the declaration
- What does `readonly` mean?
  > readonly means that a field can only be assigned a value during its declaration or in the constructor of the class, and it cannot be changed after that.
- What is wrong with the following code?

  `public const List<int> Numbers = [];`
  > You cannot use const for lists, you should use readonly. const is for value types only.
- What is wrong with the following code?

  `public readonly int Max;`
  > Nothing. Even if you do not assign a value in the constructor, it will be assigned 0 since this is the default value for an int.

## ValueTuples
- What is a value tuple?
  > A value tuple is a lightweight data structure that groups together multiple values, which can be of different types.
- Why would you use a value tuple?
  > To group together related data, the most common example being when you want to return multiple things from a method.
- How do I print out the values in this tuple?
  
  `(int, string, bool) t = (1, "hi", false);`
  > `Console.WriteLine($"{t.Item1}, {t.Item2}, {t.Item3}");`
- How do I print out the values in this tuple? Can you think of 2 ways?
  
  `(int Row, int Col) position = (3, 4);`
  >- `Console.WriteLine($"{position.Row} {position.Col}");`
  >- `Console.WriteLine($"{position.Item1} {position.Item2}");`

