Revision
---
- What is a jagged array?
    > An array of arrays
- When would you use a jagged array? Can you give an example situation?
    > When you need to store groups of data of different lengths. For example storing the names of the students in the groups in Project.
- What is in the `numbers` array after this line of code is executed? Why? 
    ```
    int[][] numbers = new int[3][];
    ```
    
    > 3 nulls `{null, null, null}`,  since `null` is the default type for arrays and we are creating an empty array of arrays. This creates a jagged array with three elements, but it hasn't initialized the inner arrays yet
- Given the following jagged array, What will `numbers.Length` tell you?
    ```
    int[][] numbers = [
        [1, 2, 3],
        [8, 3, 4, 1, 9],
        [9, 5]
    ],
    ``` 
    > 3, the amount of arrays in the array
- Given the following jagged array, What will `numbers[2].Length` tell you?
    ```
    int[][] numbers = [
        [1, 2, 3],
        [8, 3, 4, 1, 9],
        [9, 5]
    ],
    ``` 
    > 2, the amount of elements in the array at index 2
- How can you access the first element in the first array of a jagged array named `numbers`?
    > `numbers[0][0]`
- How can you access the last element in the last array of a jagged array named `numbers`?
    > `numbers[^1][^1]`
- When would you use a multidimentional array?
    > Useful when you need a grid-like structure with fixed dimensions, such as a chessboard or a matrix.
- Given the following code 
    ```
    string[,] board = new string[4, 2];
    ```
    How many rows does `board` have? How can you determine this using code?
    > 4, `board.GetLength(0)`
- Given the following code 
    ```
    string[,] board = new string[4, 2];
    ```
    How many columns does `board` have? How can you determine this using code?
    > 4, `board.GetLength(1)`
- Given the following code 
    ```
    string[,] board = new string[4, 2];
    int number = board.Length;
    ```
    What will the value of `number` be? Why?
    > 8, `Length` gives the total number of values in the multidimensional array
- How can you access the first element in a multidimensional array named `numbers`?
    > `numbers[0, 0]`
- How can you access the last element in a multidimensional array named `numbers`?
    > `numbers[number.GetLength(0) -1, numbers.GetLength(1) -1]`