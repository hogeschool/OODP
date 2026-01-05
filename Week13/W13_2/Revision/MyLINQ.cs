public class MyLINQ
{
    // MyCount
    public static int MyCount(int[] numbers, Func<int, bool> predicate)
    {
        int count = 0;
        foreach (var number in numbers)
        {
            if (predicate(number))
            {
                count++;
            }
        }
        return count;
    }

    // MyWhere
    public static int[] MyWhere(int[] numbers, Func<int, bool> predicate)
    {
        int[] result = new int[MyCount(numbers, predicate)];
        int index = 0;
        foreach (var number in numbers)
        {
            if (predicate(number))
            {
                result[index++] = number;
            }
        }
        return result;
    }
}
