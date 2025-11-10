static class Fibonacci
{
    public static int Iteratively(int n)
    {
        // Very clumsy. Not intuitive at all, and a lot of code.
        if(n == 0)
        {
            return 0;
        }
        int n0 = 0;
        int n1 = 1;

        for (int i = 0; i < n - 1; i++)
        {
            int n2 = n0 + n1;
            n0 = n1;
            n1 = n2;
        }

        return n1;
    }

    public static int Recursively(int n)
    {
        // This is a lot more intuitive and concise!
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        return 0; // Placeholder. We don't want to spoil it! See W15.1.1T01.
        // Return the sum of calling Fibonacci with n - 1 and n - 2.
    }
}