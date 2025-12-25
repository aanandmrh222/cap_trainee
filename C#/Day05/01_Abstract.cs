/*
Abstract Class --> A partially implemented class
                    Cannot be instantiated directly 

            Can contain:
            Abstract methods (no body)  --> An abstract method defines only the method signature
            Concrete methods (with body)
            Fields & constructors

Abstract method → must be overridden, Must be implemented in child class
Abstract class → can have constructors

❌ You cannot create objects of abstract classes
✅ You can create child objects using parent reference
*/

abstract class Shape
{
    public abstract double CalculateArea();
    public void Display()
    {
        Console.WriteLine("This is a shape");
    }
}

class Circle : Shape
{
    public override double CalculateArea()
    {
        return 3.14 * 5 * 5;
    }
}


abstract class Account
{
    public abstract double CalculateInterest();

    public void DisplayAccountType()
    {
        Console.WriteLine("Bank Account");
    }
}
class SavingsAccount : Account
{
    public override double CalculateInterest()
    {
        return 0.05;
    }
}


public class AbstractCaller
{
    public static void AbstractCallerMethod()
    {
        // Shape s = new Shape(); ❌ not allowed
        Shape shape = new Circle();  // creating child objects using parent reference
        Console.WriteLine("Circle Area: " + shape.CalculateArea());
        shape.Display();
    }
}