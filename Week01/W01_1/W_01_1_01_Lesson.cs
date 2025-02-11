public class W_01_1_01_Lesson_DB
{
    public static void Main() // Starting point of the application (svm tab)
    {
        // Variables name, age height initial female
        string name = "Deborah";
        int age = 10;
        double height = 110.5;
        char initial = 'D';
        bool female = true;

        // update
        age = 12;

        // var - avoid in the beginning
        var phrase = "howdy!";
        // Error must use var in one line
        // var phrase2;
        // phrase2 = "yup";

        // Operators + - * / %
        int a = 10;
        int b = 4;
        // If you divide an integer by an integer then the result is an integer with the decimal part is truncated
        int doMath = a / b;
        // If there is a double in the expression, the result will be a double
        var doMath2 = a + b + 1.0;

        //Shortcuts ++ -- (post/pre) += -= *= /= 
        int num = 1;
        int num2 = num++;
        int num3 = ++num;
        num += 10;

        // Comments (Ctrl /)
        // comment
        
        /*
         A
         long
         comment
        */

        // Output Write WriteLine (cw tab)
        Console.Write("Hello");
        Console.Write("Hi");
        Console.WriteLine("There");

        // String Concatenation + $ //Settings -> editor.quickSuggestions -> strings -> on
        string s = name + " " + age + " " + height;
        string s2 = $"{name} {age} {height}";
        Console.WriteLine(s);
        Console.WriteLine(s2);

        // Input ReadLine
        Console.WriteLine("Enter something:");
        // about warning: There is a chance that null (absence of a string) is stored
        // Will learn about null later in the course
        string input = Console.ReadLine();
        Console.WriteLine($"You wrote {input}");

        // Conversion From String to int, char, double (,) (Convert.To) Exception
        // Built in methods https://learn.microsoft.com/en-us/dotnet/api/system.convert?view=net-8.0
        var sa = Convert.ToInt32("2");
        var sb = Convert.ToChar("a");
        var sc = Convert.ToDouble("2,4");

        // Conversion Int -> Double 
        int anInt = 12;
        double aDouble = anInt;

        // Conversion Double -> Int (int) double.MaxValue  
        aDouble = double.MaxValue;
        anInt = (int)aDouble;

        anInt = Convert.ToInt32(3.14);
        // Be careful - exception (a run time error)
        // anInt = Convert.ToInt32(aDouble);

        // Types of errors
        // compiler errors
        // int x = 5 // Syntax error: missing semicolon
        // int x = 2; // Semantics error: Duplicate variables

        // Logical errors
        int average = (1 + 2) * 2;

        Console.WriteLine("For break point");

        /**********************************************
        *           W_01_1_C01 - W_01_1_C03           *
        ***********************************************/
    }
}
