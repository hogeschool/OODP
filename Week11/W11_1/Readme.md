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
int[,] board = new int[3, 3];
board[0, 0] = 1;
board[2, 1] = 5;
```

A jagged array, on the other hand, is an array of arrays — meaning each row can have a different length:
```csharp
int[][] triangle =
{
    new int[] { 1 },
    new int[] { 2, 3 },
    new int[] { 4, 5, 6 }
};
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