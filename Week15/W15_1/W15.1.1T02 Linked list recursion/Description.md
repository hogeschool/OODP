Learning goal:
- recursion with linked lists

You'll need your `Node` class from the previous assignment.

In a new class called `LinkedListUtils`, write a method `Contains` that takes two parameters:
- a `Node`
- an int value to search for

Your method should recursively check whether the linked list contains the given value. It should return `true` if the value is found, and `false` otherwise.

To help you get started, here’s the logic broken down:
- If the current node is `null`, return `false`.
- If the current node’s value equals the value we’re looking for, return `true`.
- Otherwise, recursively call `Contains` with the next node and the value.