
namespace Interfaces;

public interface IDevice
{
    bool IsOn { get; }
    void TurnOn();
}

public interface IPrinter : IDevice
{
    void Print(string text);
}

public interface IScanner : IDevice
{
    string Scan();
}

// multiple inheritance
public class Printer : IPrinter
{
    public bool IsOn {get; private set;}

    public void TurnOn()
    {
        this.IsOn = true;
        Console.WriteLine("Printer is on");
    }

    public void Print(string text)
    {
        Console.WriteLine(text);
    }
}

public class Scanner : IScanner
{
    public bool IsOn {get; private set;}

    public void TurnOn()
    {
        this.IsOn = true;
        Console.WriteLine("Scanner is on");
    }

    public string Scan()
    {
        return Console.ReadLine();
    }

    void IDevice.TurnOn()
    {
        this.IsOn = true;
        Console.WriteLine("Scanner is on");
    }
}

public class MultiFunctional : IPrinter, IScanner
{
    public bool IsOn {get; private set;}
    public void Print(string text)
    {
        Console.WriteLine(text);
    }

    public string Scan()
    {
        return Console.ReadLine();
    }

    public void TurnOn()
    {
        this.IsOn = true;
        Console.WriteLine("MultiFunctional is on");
    }
}

public class SmartMultiFunctional : IPrinter, IScanner
{
    public bool IsOn => _printer.IsOn && _scanner.IsOn;
    private readonly IPrinter _printer = new Printer();
    private readonly IScanner _scanner = new Scanner();

    public void Print(string text)
    {
        _printer.Print(text);
    }

    public string Scan()
    {
        return _scanner.Scan();
    }

    public void TurnOn()
    {
        _printer.TurnOn();
        _scanner.TurnOn();
    }

}

public class LazyMultiFunctional : IDevice
{
    public bool IsOn => Printer.IsOn && Scanner.IsOn;
    public IPrinter Printer { get; } = new Printer();
    public IScanner Scanner { get; } = new Scanner();

    public void TurnOn()
    {
        Printer.TurnOn();
        Scanner.TurnOn();
    }
}