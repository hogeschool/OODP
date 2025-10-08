static class Program
{
    static void Main()
    {
        // Create a linked list: 5 -> 2 -> 8 -> 1
        Node head = new(5, new(2, new(8, new(1))));

        Console.WriteLine("Sum: " + LinkedListUtils.SumOfValues(head));         // 16
        Console.WriteLine("Product: " + LinkedListUtils.ProductOfValues(head)); // 80
        Console.WriteLine("Highest: " + LinkedListUtils.HighestOfValues(head)); // 8
    }
}