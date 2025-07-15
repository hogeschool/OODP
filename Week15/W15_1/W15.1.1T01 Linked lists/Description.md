Learning goals:
- Linked list basics

We're taking a short break from recursion to explore linked lists.

Linked lists are the building blocks of many data structures you'll encounter, such as `Stack`s and `Queue`s. They give us more control over memory and structure than `List`s or arrays.

You'll also come across linked lists and tree structures (which you can think of as branching linked lists) in next year's **Algorithms** course.

Create a `class Node` with two public fields or properties:
- `int Value`
- `Node Next`

The constructor should take one required parameter: the value.\
It should also accept a second, optional parameter for the next node (defaulting to `null`).