/*
base same as super in java -> Both are used to refer to the parent (base) class.
    Why we use it -> To call parent class constructor, To access parent class methods or variables
    
class Parent
{
    public Parent(int x) { }
}

class Child : Parent
{
    public Child() : base(10) { }   // calls parent constructor
}

*/

/*
sealed same as final in java -> What it means -> Both prevent inheritance or modification.
  // Case 1: Prevent inheritance
        sealed class MyClass { }

  // Case 2: Prevent method overriding
        class Parent
        {
            public virtual void Show() { }
        }

        class Child : Parent
        {
            public sealed override void Show() { }
        }
*/

/*
📊 Quick comparison table
Concept	                       C#	              Java
Parent reference	          base	              super
Prevent inheritance	       sealed class	        final class
Prevent overriding	       sealed override	    final method
*/


class _23_BankAccount
{
    // protected allows access in derived class, but NOT using object reference
    protected int TimePeriod;
    protected float Principal;
    protected float ROI;

    // Parent class constructor --> Constructor executes automatically during object creation
    public _23_BankAccount(int TimePeriod, double Principal, double ROI)
    {
        Console.WriteLine("--------- PARENT BankAccount Constructor is Called");
        this.TimePeriod = 23;
        this.Principal = 2450.0f;
        this.ROI = 3.0f;
    }
}


class _23_FixedDeposit : _23_BankAccount
{
    // private by default --> accessible only inside this class
    string name;

    // base() explicitly calls parent constructor -> If parent has parameterized constructor, base() is mandatory
    public _23_FixedDeposit(string name) : base(10, 200000, 2)
    {
        Console.WriteLine("+++++ BASE BankAccount Constructor is Called");
        this.name = name;
    }

    // Method accessing protected members
    public void DisplayDetails()
    {
        Console.WriteLine($"TimePeriod is ::>> {TimePeriod}");
        Console.WriteLine($"Principal is ::>> {Principal}");
        Console.WriteLine($"ROI is ::>> {ROI}");
    }
}



// ++++++++ SINGLE INHERITANCE -> One child class inherits from one parent class.
class _23_Vehicle
{
    public _23_Vehicle()
    {
        Console.WriteLine("Vehicle Base Call");
    }

    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}

class _23_Car : _23_Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}


/*
CONSTRUCTOR CHAINING --> If parent has parameterized constructor, child MUST call it using base().
If base() is not used → compile-time error
*/

class _23_Person
{
    public string Name;

    public _23_Person(string name)
    {
        Name = name;
    }
}

class _23_Student : _23_Person
{
    public int RollNo;
    // base(name): -> Passes value to parent constructor, Ensures proper initialization
    public _23_Student(string name, int roll) : base(name)
    {
        RollNo = roll;
    }
}


// ++++++++ MULTILEVEL INHERITANCE -> Inheritance chain:
        // Employee → Human → LivingBeing --> Each level adds its own behavior
class _23_LivingBeing
{
    public void Breathe()
    {
        Console.WriteLine("Breathing");
    }
}

class _23_Human : _23_LivingBeing
{
    public void Think()
    {
        Console.WriteLine("Thinking");
    }
}

class _23_Employee : _23_Human
{
    public void Work()
    {
        Console.WriteLine("Working");
    }
}


// ++++++++ HIERARCHICAL INHERITANCE --> One parent class with multiple child classes
               // Shape → Circle, Shape → Rectangle
class _23_Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing shape");
    }
}
class _23_Circle : _23_Shape
{
    // Inherits Draw() from Shape
}

class _23_Rectangle : _23_Shape
{
    // Inherits Draw() from Shape
}


