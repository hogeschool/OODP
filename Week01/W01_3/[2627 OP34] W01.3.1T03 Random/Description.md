## Learning goals
- Creating a `Random` object
- Generating random integers
- Using `Random.Next()`

## Assignment
You are rolling a die 10 times.

Write a C# version of this Python program:
```python
import random

sides = int(input("How many sides does the die have? "))

for i in range(10):
    roll = random.randint(1, sides)
    print(f"You rolled a {roll}")
```

The program should print something like:

```text
How many sides does the die have? 6
The robot rolled a 4
The robot rolled a 3
// etc...
```

### Pointers
You can create a `Random` object and generate integers like this:
```c#
Random random = new Random(0); // Seeded random, making the outcomes predictable
random.Next(1, 10); // Random int from 1 to 9
```

Note: if you want actual random ints, change `new Random(0)` to `new Random()` so that it's no longer seeded.