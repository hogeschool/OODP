// The base case and step are necessary to prevent a
// `NullReferenceException` at the end of the linked list.

static class LinkedListUtils
{
    public static int SumOfValues(Node node)
    {
        if (node == null) // Base case
            return 0; // Base step
        return node.Value + SumOfValues(node.Next); // Recursive case & step
    }
    
    public static int ProductOfValues(Node node)
    {
        if (node == null) // Base case
            return 1; // Base step (think--why is this 1 instead of 0?)
        return node.Value * ProductOfValues(node.Next); // Recursive case & step
    }
    
    public static int HighestOfValues(Node node) => HighestValue(node, int.MinValue);
    public static int HighestOfValues(Node node) => HighestOfValues(node, int.MinValue);

    private static int HighestOfValues(Node node, int currentHighest)
    {
        if (node == null)
            return currentHighest;

        int newHighest = Math.Max(currentHighest, node.Value);
        return HighestOfValues(node.Next, newHighest);
    }
}