Revision
---
- What is a jagged array?
- When would you use a jagged array? Can you give an example situation?
- What is in the `numbers` array after this line of code is executed? Why? 
    ```
    int[][] numbers = new int[3][];
    ```
    
- Given the following jagged array, What will `numbers.Length` tell you?
    ```
    int[][] numbers = [
        [1, 2, 3],
        [8, 3, 4, 1, 9],
        [9, 5]
    ],
    ``` 
- Given the following jagged array, What will `numbers[2].Length` tell you?
    ```
    int[][] numbers = [
        [1, 2, 3],
        [8, 3, 4, 1, 9],
        [9, 5]
    ],
    ``` 
- How can you access the first element in the first array of a jagged array named `numbers`?
- How can you access the last element in the last array of a jagged array named `numbers`?
- When would you use a multidimentional array?
- Given the following code 
    ```
    string[,] board = new string[4, 2];
    ```
    How many rows does `board` have? How can you determine this using code?
- Given the following code 
    ```
    string[,] board = new string[4, 2];
    ```
    How many columns does `board` have? How can you determine this using code?
- Given the following code 
    ```
    string[,] board = new string[4, 2];
    int number = board.Length;
    ```
    What will the value of `number` be? Why?
- How can you access the first element in a multidimensional array named `numbers`?
- How can you access the last element in a multidimensional array named `numbers`?