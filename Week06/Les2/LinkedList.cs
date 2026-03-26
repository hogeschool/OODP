
public class LinkedListNode<T>
{
    public T Value { get; set; }
    public LinkedListNode<T>? Next { get; set; }
}

// visual explanin linked list
// [value | Next]
//          [value | Next]

// [1 | Next]
//        [2 | Next]
//              null