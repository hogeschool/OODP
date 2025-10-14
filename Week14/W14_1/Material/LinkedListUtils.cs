// The base case is necessary to prevent a
// `NullReferenceException` at the end of the linked list.

static class LinkedListUtils
{
    public static int SumOfValues(Node node)
    {
        if (node == null) // Base case
            return 0;
        // else: recursive case
        return node.Value + SumOfValues(node.Next); // Recursive call: SumOfValues(node.Next), recursive step: node.Next
    }
    
    public static int ProductOfValues(Node node)
    {
        if (node == null) // Base case
            return 1; // Think--why is this 1 instead of 0?
        // else: recursive case
        return node.Value * ProductOfValues(node.Next);
    }
    
    public static int HighestOfValues(Node node) => HighestOfValues(node, node.Value); // Take the first node's Value (node.Value) as the highest to start with
    private static int HighestOfValues(Node node, int currentHighest)
    {
        if (node == null)
            return currentHighest;

        int newHighest = Math.Max(currentHighest, node.Value);
        return HighestOfValues(node.Next, newHighest);
    }
}