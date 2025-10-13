# Week 11

## Day 1 (W11.1)

### Contents:

PART 1: jagged arrays
* looping (W11.1.1T01)
* creating (W11.1.1T02)
PART 2: 2D arrays
* creating (W11.1.1T03)
* looping (W11.1.1T04)

### Summary
So far, you’ve worked with 1D arrays — simple linear collections of data.\
But sometimes, data naturally fits into a grid or table, such as a chessboard, a seating plan, or an image.

That’s where 2D arrays come in: they allow you to store elements in rows and columns, accessed using two indices:
```csharp
int[,] grid = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9],
};

for (int row = 0; row < grid.GetLength(0); row++)
{
    for (int col = 0; col < grid.GetLength(1); col++)
    {
        Console.Write(grid[row, col] + " ");
    }
    Console.WriteLine();
}
```

A jagged array, on the other hand, is an array of arrays — meaning each row can have a different length:
```csharp
int[][] jagged = [
    [1, 2, 3],
    [4, 5],
    [6, 7, 8, 9],
];

for (int row = 0; row < jagged.Length; row++)
{
    for (int col = 0; col < jagged[row].Length; col++)
    {
        Console.Write(jagged[row][col] + " ");
    }
    Console.WriteLine();
}
```

This flexibility makes jagged arrays perfect for structures like triangles, game maps, or irregular grids.


| Feature | **2D Array (`[,]`)** | **Jagged Array (`[][]`)** |
|----------|-----------------------|---------------------------|
| Structure | Rectangular grid | Array of arrays |
| Row length | Always the same | Can vary per row |
| Syntax | `int[,] grid = new int[3,3];` | `int[][] grid = new int[3][];` |
| Access | `grid[row, col]` | `grid[row][col]` |
| Memory layout | Continuous block | Separate arrays per row |
| Flexibility | Rigid, but compact | More flexible, but less memory-efficient |


### What You’ll Learn
By the end of this part about jagged and 2D arrays, you’ll be comfortable with:
- Declaring
- Initializing
- Accessing elements
- Iterating through them using nested loops

Understanding when to use 2D arrays (grids) and when to use jagged arrays (uneven data)