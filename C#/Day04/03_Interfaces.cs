/*
MULTIPLE INHERITANCE USING INTERFACES
    Important: C# does NOT support multiple inheritance using classes
               Interfaces are used instead to avoid ambiguity
*/

using System;

interface _23_IPrintable
{
    void Print();
}

interface _23_IScannable
{
    // Interfaces can have same method names -> No ambiguity because class provides implementation
    void Print();
    void Scan();
}

class _23_Machine : _23_IPrintable, _23_IScannable
{
    // Single Print() implementation satisfies both interfaces
    
    public void Print()
    {
        Console.WriteLine("Printing");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning");
    }
}