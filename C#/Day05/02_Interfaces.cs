/*
Interface -->> 100% contract (what to do, not how), Supports multiple inheritance
    Contains:
      Method declarations
      Properties (no fields)
*/

interface IPrint
{
    void Print();
}

interface IScan
{
    void Scan();
}

class Printer : IPrint, IScan
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }
}


// Explicit Interface Implementation
interface IA
{
    void Show();
}

interface IB
{
    void Show();
}

class Test : IA, IB
{
    void IA.Show()
    {
        Console.WriteLine("IA Show");
    }

    void IB.Show()
    {
        Console.WriteLine("IB Show");
    }
}


class InterfaceCaller
{
    public static void InterfaceCallerMethod()
    {
        // Using class object
        Printer printer = new Printer();
        printer.Print();
        printer.Scan();

        Console.WriteLine();

        // Using interface reference (polymorphism)
        IPrint printDevice = new Printer();
        printDevice.Print();

        IScan scanDevice = new Printer();
        scanDevice.Scan();


        IA a = new Test();
        a.Show();

        IB b = new Test();
        b.Show();
    }
}

