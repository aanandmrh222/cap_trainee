using System;

class IndexerCaller
{
    public static void IndexerCallerMethod()
    {
        //---------------DAY4---24---Getter-Setters----------------------------
        Console.WriteLine("");

        // ---------------- EMPLOYEE ----------------
        _24_Employee e = new _24_Employee();   // object creation
        e.Salary = 40000;                      // setter called

        Console.WriteLine("Employee Salary");
        Console.WriteLine(e.Salary);            // getter called
        Console.WriteLine("--------------------------------");


        // ---------------- PRODUCT ----------------
        _24_Product p = new _24_Product();     // object creation
        p.ProductId = 101;                     // set property
        p.ProductName = "Laptop";              // set auto property
        p.Price = 55000;                       // set auto property

        Console.WriteLine("Product Details");
        Console.WriteLine(p.ProductId);
        Console.WriteLine(p.ProductName);
        Console.WriteLine(p.Price);
        Console.WriteLine("--------------------------------");


        // ---------------- STUDENT ----------------
        _24_Student s = new _24_Student();     // object creation
        s.RollNo = 1;                          // set auto property
        s.Name = "Sandeep";                    // set auto property
        s.Course = "CSE";                      // set auto property

        Console.WriteLine("Student Details");
        Console.WriteLine(s.RollNo);
        Console.WriteLine(s.Name);
        Console.WriteLine(s.Course);
        Console.WriteLine("--------------------------------");


        // ---------------- CIRCLE ----------------
        _24_Circle c = new _24_Circle(5);      // constructor call

        Console.WriteLine("Circle Area");
        Console.WriteLine(c.Area);              // read-only property
        Console.WriteLine("--------------------------------");


        //-----------------EXPRESSION-BODIED-OPERATOR-------------------
        _25_Rectangle recObj = new _25_Rectangle();
        recObj.Length = 12;
        recObj.Width = 12;
        Console.WriteLine($"Area of the rectangle is ::>> {recObj.Area}");



        // //---------DAY4---25--Get--Set---------------------------
        Console.WriteLine("");
        _25_Student stuObj = new _25_Student();
        stuObj.Name = "Sandeep";
        stuObj.Age = 23;
        stuObj.Marks = 68;

        stuObj.DisplayDetails();



        // //----------DAY4---26--Indexer----------------------------
        Console.WriteLine("");

        _26_StudentCollection stuObj1 = new _26_StudentCollection();
        stuObj1.SetStudent(0,"Sandeep");
        Console.WriteLine($"Getting the Student data 0 ::>> {stuObj1.GetStudent(0)}");
    }
}