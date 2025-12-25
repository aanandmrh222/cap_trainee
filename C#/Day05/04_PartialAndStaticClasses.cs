// Partial Classes --> Class split across multiple files
// A Partial Class allows a single class to be split across multiple files, 
//  while the compiler treats all parts as one single class at compile time

partial class Employee
{
    public void Work() { }
}

partial class Employee
{
    public void Salary() { }
}


// A Static Class is a special type of class in C# designed to group 
//  related utility or helper methods that do not depend on object state.
// static class -->> Only static members, 
//                   Cannot create object direct access with class name
//                   Cannot inherit
static class Utility
{
    public static void Log()
    {
        Console.WriteLine("Logging...");
    }
}
