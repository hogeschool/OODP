## Learning goals
- switch expression/statement

## Assignment
Write a program with a switch expression to determine whether a given age is that of:
- a child (age is between 0 and 12 inclusive)
- a teenager (age is between 13 and 19 inclusive)
- an adult (age is between 20 and 150 inclusive)
- an invalid age (any other number)

Example 1:
```
Enter an age:
>12
Age 12: a child
```

Example 2:
```
Enter an age:
>-1
Age -1: invalid
```

## Pointers
A switch expression is written like this:
```c#
Console.Write("Enter a direction (N, E, S or W): ");
string input = Console.ReadLine().ToUpper();

string direction = input switch
{
    "N" => "North",
    "E" => "East",
    "S" => "South",
    "W" => "West",
    _ => "Invalid direction"
};

Console.WriteLine(direction);
```