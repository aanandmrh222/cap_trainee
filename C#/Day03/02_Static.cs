/*
Static Fields -> A static field belongs to the class itself, not to any specific object.

This means:
    ✅Only one copy of the static field exists
    ✅All objects of the class share the same value
    ✅Static fields are accessed using the class name

Static fields are used for common data that should be the same for all objects.

--------------- Syntax Example
class Bank
{
    public static string BankName = "SBI";
}
Accessing static field:
Console.WriteLine(Bank.BankName);

Key Points (Static):
    ✅Memory allocated once
    ✅Shared among all objects
    ✅Accessed using ClassName.FieldName (without creating the object of class)
    ✅Useful for common/global information

*/

/*
6. Static Methods: 
    Static methods are methods that belong to the class itself, not to any specific object.
    They can be called directly using the class name, without creating an object.
    Static methods are mainly used for common functionality that does not depend on object-specific data.


------------Key Characteristics of Static Methods
        Belong to the class, not an instance
        Can be called using ClassName.MethodName()
        Cannot access non-static (instance) fields or methods directly
        Commonly used for utility and helper operations
        Improve memory efficiency (no object creation needed)

class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

int sum = Calculator.Add(5, 10);

*/
