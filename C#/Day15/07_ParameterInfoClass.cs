using System;
using System.Reflection;

namespace ReflectionParameterInfoDemo
{
    // ---------------- STUDENT CLASS ----------------
    public class Student
    {
        // Constructor with optional parameter
        public Student(int id, string name = "DefaultName")
        {
        }

        // Method with parameters
        public void Update(int marks, string grade = "A")
        {
        }
    }

    class ParameterInfoClass
    {
        public static void ParameterInfoClassMain()
        {
            Type type = typeof(Student);

            Console.WriteLine("===== CONSTRUCTOR PARAMETER INFO =====\n");

            // Get constructor
            ConstructorInfo ctor =
                type.GetConstructor(new Type[] { typeof(int), typeof(string) });

            // GetParameters()
            ParameterInfo[] ctorParams = ctor.GetParameters();

            foreach (ParameterInfo p in ctorParams)
            {
                Console.WriteLine("Name            : " + p.Name);
                Console.WriteLine("ParameterType   : " + p.ParameterType);
                Console.WriteLine("Position        : " + p.Position);
                Console.WriteLine("IsOptional      : " + p.IsOptional);
                Console.WriteLine("HasDefaultValue : " + p.HasDefaultValue);
                Console.WriteLine("DefaultValue    : " + p.DefaultValue);
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n===== METHOD PARAMETER INFO =====\n");

            // Get method
            MethodInfo method = type.GetMethod("Update");

            // GetParameters()
            ParameterInfo[] methodParams = method.GetParameters();

            foreach (ParameterInfo p in methodParams)
            {
                Console.WriteLine("Name            : " + p.Name);
                Console.WriteLine("ParameterType   : " + p.ParameterType);
                Console.WriteLine("Position        : " + p.Position);
                Console.WriteLine("IsOptional      : " + p.IsOptional);
                Console.WriteLine("HasDefaultValue : " + p.HasDefaultValue);
                Console.WriteLine("DefaultValue    : " + p.DefaultValue);
                Console.WriteLine("----------------------------------");
            }

        }
    }
}
