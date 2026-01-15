using System;
using System.Reflection;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Parameterless constructor
    public Employee()
    {
        Console.WriteLine("Employee default constructor called");
    }

    // Parameterized constructor
    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Employee parameterized constructor called");
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {

        // ASSEMBLY
        Assembly assembly = Assembly.GetExecutingAssembly();
        Console.WriteLine("Assembly Full Name:");
        Console.WriteLine(assembly.FullName);

        // TYPE
        Type employeeType = typeof(Employee);
        Console.WriteLine("\nType Name:");
        Console.WriteLine(employeeType.FullName);

        // PROPERTY INFO
        Console.WriteLine("\nProperties:");
        PropertyInfo[] properties = employeeType.GetProperties();
        foreach (PropertyInfo prop in properties)
        {
            Console.WriteLine($"{prop.PropertyType.Name} {prop.Name}");
        }

        // METHOD INFO
        Console.WriteLine("\nMethods:");
        MethodInfo[] methods = employeeType.GetMethods(
            BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }

        // CONSTRUCTOR INFO
        Console.WriteLine("\nConstructors:");
        ConstructorInfo[] constructors = employeeType.GetConstructors();

        foreach (ConstructorInfo ctor in constructors)
        {
            Console.WriteLine(ctor);
        }

        // CREATE OBJECT USING ConstructorInfo (NO new KEYWORD)

        // Parameterless constructor
        ConstructorInfo defaultCtor = employeeType.GetConstructor(Type.EmptyTypes);

        object emp1 = defaultCtor.Invoke(null);

        // Parameterized constructor
        ConstructorInfo paramCtor = employeeType.GetConstructor(new Type[] { typeof(string), typeof(int) });

        object emp2 = paramCtor.Invoke(new object[] { "Aanand", 20 });

        // INVOKE METHOD USING REFLECTION
        employeeType.GetMethod("Display").Invoke(emp2, null);















        /* 
        // ReflectionAssemblyDemo.AssemblyClassCaller.AssemblyClassCallerMain();
        // ReflectionTypeDemo.TypeClassCaller.TypeClassCallerMain();
        // ReflectionFieldInfoDemo.FileInfoClass.FileInfoClassMain();
        // ReflectionPropertyInfoDemo.PropertyInfoClass.PropertyInfoClassMain();
        // ReflectionMethodInfoDemo.MethodInfoClass.MethodInfoClassMain();
        // ReflectionConstructorInfoDemo.ConstructorInfoClass.ConstructorInfoClassMain();
        // ReflectionParameterInfoDemo.ParameterInfoClass.ParameterInfoClassMain();
        // ReflectionEventInfoDemo.EventInfoClass.EventInfoClassMain();
        // ReflectionMemberInfoDemo.MemberInfoClass.MemberInfoClassMain();
        ReflectionAttributeDemo.AttributeClass.AttributeClassMain();
        */
    }
}



/*

using System;
using System.Reflection;

class Employee
{
    public string Name { get; set; }
    private int _salary = 30000;

    public void Work()
    {
        Console.WriteLine("Employee is working");
    }
    public Employee() { }
    public Employee(string name, int age)
    {
        Console.WriteLine(name + " " + age);
    }
    public void Working(string task, int hours) { }
}

class Program
{
    static void Main()
    {
        Employee employeeObject = new Employee();

        Type t1 = typeof(Employee);//info about the Employee class at compile time
        Type t2 = employeeObject.GetType();//type of this object while the program is running
        Type t3 = Type.GetType("Employee");//find class by its name as a string while the program is running
        object obj3 = Activator.CreateInstance(t1);//creatrs object when you dont know the name,via type

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);

        //method indo -info of method
        MethodInfo method = t1.GetMethod("Work"); //search for method names "work"
        method.Invoke(employeeObject, null);//call the method by the object which owns it and parameter is null

        //proprty info
        PropertyInfo prop = t2.GetProperty("Name");//Go inside this class and find a property called Name
        prop.SetValue(employeeObject, "John");//Put the value John into the Name property of this object
        Console.WriteLine(employeeObject.Name);//john

        //Field info-change class varaiable even private at runtime
        FieldInfo field = t2.GetField(
            "_salary",//search for varaiable called _salary
            BindingFlags.NonPublic | BindingFlags.Instance         //if field is not static
        );//allow access to private | look for feild that belong to an object
        Console.WriteLine(field.GetValue(employeeObject)); // read
        field.SetValue(employeeObject, 50000);              // write
        Console.WriteLine(field.GetValue(employeeObject));

        //constructor info
        ConstructorInfo ctor1 = t1.GetConstructor(Type.EmptyTypes);//Find the constructor that takes no input
        object obj1 = ctor1.Invoke(null); //Create an object using that constructor
        Console.WriteLine(obj1.GetType().Name);

        ConstructorInfo ctor = t1.GetConstructor(
            new Type[] { typeof(string), typeof(int) }
        );//Order must match exactly
        object obj = ctor.Invoke(new object[] { "John", 25 });//obj with parameters
        Console.WriteLine(obj.GetType().Name);

        //Parameter info -parameter of method or constructor
        MethodInfo method1 = t1.GetMethod("Working");
        ParameterInfo[] parameters = method1.GetParameters();//Reads all input arguments of that method
        foreach (var p in parameters)
        {
            Console.WriteLine(p.Name + " - " + p.ParameterType);
        }

        Assembly assembly = Assembly.GetExecutingAssembly();

        foreach (Type type in assembly.GetTypes())
        {
            // Show only Employee class
            if (type.Name == "Employee")
            {
                Console.WriteLine("Class: " + type.Name);

                // foreach (MethodInfo m in type.GetMethods())   //all methods , public methods inhertited from object class
                // {
                //     Console.WriteLine("  Method: " + m.Name);
                // }

                foreach (MethodInfo m in type.GetMethods(
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))//only my methods
                    {
                        Console.WriteLine("  Method: " + m.Name);
                    }
            }
        }

    }
}

*/










