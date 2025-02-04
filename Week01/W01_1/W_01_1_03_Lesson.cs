public static class DB_W_01_1_03_Lesson
{
    public static void SwitchStatementAndExpression()
    {
        // What does the following code do?
        Console.WriteLine("Enter a number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a symbol");
        string symbol = Console.ReadLine();

        string result = $"{num1} {symbol} {num2} = ";


        if (symbol == "+")
        {
            result += (num1 + num2);
        }
        else if (symbol == "-")
        {
            result += (num1 - num2);
        }
        else if (symbol == "*")
        {
            result += (num1 * num2);
        }
        else if (symbol == "/")
        {
            result += (num1 / num2);
        }
        else
        {
            result += "Operation not supported";
        }
        Console.WriteLine(result);

        // switch statement
        // switch ([expression])
        // {
        //     case [value1]:
        //         [statement1];
        //         break;
        //     default:
        //         [default statement];
        //         break;
        // }
        string result2 = $"{num1} {symbol} {num2} = ";
        switch (symbol)
        {
            case "+":
                result2 += (num1 + num2);
                break;
            case "-":
                result2 += (num1 - num2);
                break;
            case "*":
                result2 += (num1 * num2);
                break;
            case "/":
                result2 += (num1 / num2);
                break;
            default:
                result += "Operation not supported";
                break;
        }

        // switch expression 
        // var val = [expression] switch
        // {
        //     value1 => expression1;
        //     _ => defaultExpression
        // };
        string result3 = $"{num1} {symbol} {num2} = ";

        result3 += symbol switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" => num1 / num2,
            _ => "Operation not supported"
        };


        //Switch Expressions with the relational pattern
        // Weekday: >=1 and <=5, Weekend: 6 or 7, error
        int day = 3;
        string result4 = day switch
        {
            >= 1 and <= 5 => "Weekday",
            6 or 7 => "Weekend",
            _ => "Error"
        };
        //     Class Exercises: W_01_1_C08 - W_01_1_C09
        Console.WriteLine();
    }
}
