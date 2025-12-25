/*
==================== NOTES ON PROPERTIES ====================

1. Property is used to access private data members safely.
2. It supports encapsulation (data hiding).
3. Property contains:
   - get  -> read value
   - set  -> assign value
4. Auto-implemented property:
   - No backing field needed
   - Compiler creates it automatically
5. Read-only property contains only get.
6. 'value' keyword stores assigned value in setter.

Property Syntax:

access_modifier data_type PropertyName
{
    get { return field; }
    set { field = value; }
}

Auto-Implemented Property Syntax:

access_modifier data_type PropertyName { get; set; }

==============================================================
*/
class _24_Employee
{
    private double salary;                 // private backing field

    public double Salary                   // property with custom logic
    {
        get
        {
            Console.WriteLine("Get is called"); // shows getter execution
            return salary;                      // return salary
        }
        set
        {
            salary = value;                    // assign value to salary
        }
    }
}

class _24_Product
{
    private int productId;                 // backing field for ProductId

    public int ProductId                  // normal property
    {
        get { return productId; }          // returns private field value
        set { productId = value; }         // assigns value to private field
    }

    public string? ProductName { get; set; } // auto-implemented property
    public double Price { get; set; }       // auto-implemented property
}

class _24_Student
{
    public int RollNo { get; set; }         // auto-implemented property
    public string? Name { get; set; }        // auto-implemented property
    public string? Course { get; set; }      // auto-implemented property
}

class _24_Circle
{
    private double radius;                 // private data member

    public _24_Circle(double r)                // constructor
    {
        radius = r;                        // initialize radius
    }

    public double Area                     // read-only property
    {
        get
        {
            return Math.PI * radius * radius; // calculate area
        }
    }
}