Learning goals:
- `switch` statements

Write a program which asks for a direction, either _"up"_, _"down"_, _"left"_, or _"right"_ (case should not matter). Use a `switch` statement in your solution.

Given an X and Y position which both start at 0, if the user enters:
- _Up_ -> increase `y` by 1
- _Down_ -> decrease `y` by 1
- _Right_ -> increase `x` by 1
- _Left_ -> decrease `x` by 1
- For any other value, print "_Invalid direction_".

Then print the current `x` and `y` values.

Example 1:
```
What direction (up/down/left/right) would you like to go?
>up
X:0, Y:1
```

Example 2:
```
What direction (up/down/left/right) would you like to go?
>spin
Invalid direction
X:0, Y:0
```