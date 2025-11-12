Revision
---
- What is an array?
- When would you use an array instead of a List?
    > - The size of your data is fixed, and/or
    > - Your data is fixed, and/or
    > - you will frequently access elements, and/or   
    > - memory/processing efficiency is important
- When would you use a list instead of an array?
    > - You do not have a fixed size for your data
    > - You will frequently insert and/or delete elements
- What will the value of `n` be in the following code? Why?
    ```
    int[] numbers = {5, 9, 1, 6};
    int n = numbers[1];
    ```
    > 9 because arrays are zero-indexed, meaning the first element is at index 0
- How do you get the number of elements in an array named `array`?
    > `array.Length`
- How do you get the last element in an array named `array`?
    > `array[^1]`
- What are the contents of an array when it is declared using the following syntax `type[] name = new type[size];`? 
    > the default value for that type
- What will the value of `numbers[0]` be after the following code has executed? Why?
    ```
    int[] numbers = [7, 9, 4, 8, 4, 3];
    int[] duplicate = numbers;
    duplicate[0] = 1;
    ```
    > 1, duplicate stores a copy of the reference to the array, not a copy of the array itself.
