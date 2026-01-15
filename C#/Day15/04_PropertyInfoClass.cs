using System;
using System.Reflection;

namespace ReflectionPropertyInfoDemo
{
    // ---------------- STUDENT CLASS ----------------
    public class Student
    {
        public int Id { get; set; }              // Read & Write
        public string Name { get; private set; } // Read only (outside class)
        public int Age { get; }                  // Read only

        public Student()
        {
            Age = 20;
            Name = "Aanand";
        }

        public void UpdateName(string name)
        {
            Name = name;
        }
    }

    class PropertyInfoClass
    {
        public static void PropertyInfoClassMain()
        {
            Student student = new Student();

            // Get Type
            Type type = typeof(Student);

            Console.WriteLine("===== PROPERTY METADATA =====\n");

            // Get all properties
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo prop in properties)
            {
                Console.WriteLine("Property Name   : " + prop.Name);
                Console.WriteLine("Property Type   : " + prop.PropertyType);
                Console.WriteLine("CanRead         : " + prop.CanRead);
                Console.WriteLine("CanWrite        : " + prop.CanWrite);
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n===== PROPERTY ACCESS METHODS =====\n");

            // Get specific properties
            PropertyInfo idProp = type.GetProperty("Id");
            PropertyInfo nameProp = type.GetProperty("Name");

            // GetValue(object obj)
            Console.WriteLine("Before Change:");
            Console.WriteLine("Id   : " + idProp.GetValue(student));
            Console.WriteLine("Name : " + nameProp.GetValue(student));

            // SetValue(object obj, object value)
            idProp.SetValue(student, 101);

            // Private setter - allowed via Reflection
            nameProp.SetValue(student, "Kumar");

            Console.WriteLine("\nAfter Change:");
            Console.WriteLine("Id   : " + idProp.GetValue(student));
            Console.WriteLine("Name : " + nameProp.GetValue(student));

            Console.WriteLine("\n===== ACCESSOR METHODS =====\n");

            // GetAccessors()
            MethodInfo[] accessors = nameProp.GetAccessors(true);
            Console.WriteLine("GetAccessors:");
            foreach (MethodInfo m in accessors)
            {
                Console.WriteLine(m.Name);
            }

            // GetGetMethod()
            MethodInfo getMethod = nameProp.GetGetMethod(true);
            Console.WriteLine("\nGetGetMethod:");
            Console.WriteLine(getMethod.Name);

            // GetSetMethod()
            MethodInfo setMethod = nameProp.GetSetMethod(true);
            Console.WriteLine("\nGetSetMethod:");
            Console.WriteLine(setMethod.Name);

        }
    }
}
