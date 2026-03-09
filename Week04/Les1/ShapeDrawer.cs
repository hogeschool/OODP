using System;

namespace Les1;

public static class ShapeDrawer
{
    public static void DrawHorizontalLine()
    {
        for(int i = 0; i < 20; i++)
        {
            Console.Write("-");
        }
        // next content on new line.
        Console.WriteLine();
    }

    public static void DrawHorizontalLine(int length)
    {
        for(int i = 0; i < length; i++)
        {
            Console.Write("-");
        }
        // next content on new line.
        Console.WriteLine();
    }

    public static void DrawHorizontalLine(int length, string symbol)
    {
        for(int i = 0; i < length; i++)
        {
            Console.Write(symbol);
        }
        // next content on new line.
        Console.WriteLine();
    }

    public static void DrawCircle(
        double sizePercentage,
        double positionLeftPercentage, 
        double positionTopPercentage,         
        string color,
        bool filled
        )
    {
        // implementation
    }

    public static void DrawCircle(
        double sizePercentage,
        double positionLeftPercentage, 
        double positionTopPercentage,
        string color
        )
    {
        DrawCircle(sizePercentage, positionLeftPercentage, positionTopPercentage, color, false);
    }

    public static void DrawCircle(
        double sizePercentage,
        double positionLeftPercentage, 
        double positionTopPercentage
        )
    {
        DrawCircle(sizePercentage, positionLeftPercentage, positionTopPercentage, "black", false);
    }
}
