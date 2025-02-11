public class W_01_1_02_Lesson_DB
{
    public static void Main()
    {
        // String Methods Length ToUpper ToLower
        // https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0

        string s1 = "hello";
        int len = s1.Length;
        string s2 = s1.ToUpper();
        string s3 = s1.ToLower();
        s3.ToUpper();

        // String Equality
        string s4 = "hello";
        var eq1 = s1 == s2;
        var eq2 = s1 == s4;

        // String Escape Sequences \n \t \" \' \\
        string escChars = "Hi\nThere\tYou! \\ \" \'";
        Console.WriteLine(escChars);

        // Relational Operators < <= > >= != ==
        int num1 = 1, num2 = 2;
        bool check = num1 == num2;

        //    * Logical Operators not and or 
        bool cold = true;
        bool raining = false;

        bool hot = !cold; // not
        bool wearCoat = cold || raining; // or
        bool stayIn = cold && raining; // and

        // Selection If / Else + Scope [odd even + secret]
        string result = "";
        if (num1 % 2 == 0)
        {
            result = "even";
            string mySecret = "shhhh";
        }
        else
        {
            result = "odd";
        }

        //    * Selection Ternary C ? T : F
        string result2 = num1 % 2 == 0 ? "even" : "odd";

        //    * Selection If / Else / If Else [+ve -ve 0]
        if (num1 < 0)
        {
            result = " negative";
        }
        else if (num1 > 0)
        {
            result = " negative";
        }
        else
        {
            result = " 0";
        }

        //     Class Exercises: W_01_1_1T04 - W_01_1_1T07
        Console.WriteLine();
    }
}
