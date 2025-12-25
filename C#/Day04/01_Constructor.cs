/*
A constructor is a special method in a class that is automatically called when an object of the class is created
1. A constructor is a special member of a class.
2. Constructor name MUST be same as class name.
3. Constructor does NOT have a return type (not even void).
4. Constructor is automatically called when an object is created.
5. Used to initialize data members of a class.
6. If no constructor is written, compiler provides a default constructor.
7. "this" keyword refers to current object of the class.
8. Methods and constructors are different.
9. A constructor cannot be called like a normal method.
10. Constructor executes only once per object creation.
*/

using System;
class Constructor1
{
    // string name;
    // int rollNo;
    // static string collegeName;

    public string name { get; set; }
    public int rollNo { get; set; }
    static string collegeName;

    // STATIC CONSTRUCTOR -> Called only once, Executes before any object is created, Used to initialize static data
    static Constructor1()
    {
        collegeName = "LPU";
        Console.WriteLine("Static Constructor Called");
    }

    // DEFAULT CONSTRUCTOR
    public Constructor1() {
        this.name = "Aanand";
        this.rollNo = 25;
        Console.WriteLine("Default Constructor Called");
    }

    // PARAMETERIZED CONSTRUCTOR -> Used to pass values during object creation
    public Constructor1(string name, int roll)
    {
        this.name = name;
        rollNo = roll;
        Console.WriteLine("PARAMETERIZED Constructor Called");
    }

    // NORMAL METHOD (NOT CONSTRUCTOR)
    public void ResetDetails()
    {
        this.name = "Aanand";
        this.rollNo = 25;
        Console.WriteLine("Normal Method Called");
    }

    // OVERLOADED CONSTRUCTOR 
    public Constructor1(string name)
    {
        name = name;
        rollNo = 0;
        Console.WriteLine("Overloaded Constructor (Name only) Called");
    }

    // 

    // DISPLAY METHOD
    public void DisplayDetails()
    {
        Console.WriteLine("--------------DATA--------------");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Roll : {rollNo}");
        Console.WriteLine($"College : {collegeName}");
    }
}


class ConstructorCaller
{
    public static void ConstructorCallerMethod()
    {
        // Using constructors
        Constructor1 obj1 = new Constructor1();
        obj1.DisplayDetails();

        Constructor1 obj2 = new Constructor1("Ayush", 24);
        obj2.DisplayDetails();

        Constructor1 obj3 = new Constructor1("Raushan");
        obj3.DisplayDetails();

        // obj1.ResetDetails();

        // OBJECT INITIALIZER 
        Constructor1 obj4 = new Constructor1
        {
            name = "Karan",
            rollNo = 30
        };
        obj4.DisplayDetails();
    }
}



/*
Update fields to properties (required for object initializer)
public string Name { get; set; }
public int RollNo { get; set; }
static string collegeName;

4. Object Initializers
Object initializers allow setting values of public properties or fields without explicitly calling a constructor with parameters.
Example
Product p = new Product
{
    Name = "Laptop",
    Price = 50000
};

*/