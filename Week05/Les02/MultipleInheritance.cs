// See https://aka.ms/new-console-template for more information

namespace MultipleInheritance;

// multiple inheritance
public class Printer
{
    public void TurnOn()
    {
        Console.WriteLine("Printer is on");
    }

    public void Print(string text)
    {
        Console.WriteLine(text);
    }
}

public class Scanner
{
    public void TurnOn()
    {
        Console.WriteLine("Scanner is on");
    }

    public string Scan()
    {
        return Console.ReadLine();
    }
}

// is niet toegestaan
public class MultiFunctional: Printer, Scanner
{
    
}



