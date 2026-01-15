using System;
using System.Reflection;

namespace ReflectionConstructorInfoDemo
{
    // ---------------- STUDENT CLASS ----------------
    public class Student
    {
        public int Id;
        public string Name;

        // Public constructor
        public Student()
        {
            Id = 0;
            Name = "Default";
        }

        // Public parameterized constructor
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Private constructor
        private Student(int id)
        {
            Id = id;
            Name = "Private Constructor";
        }
    }

    class ConstructorInfoClass
    {
        public static void ConstructorInfoClassMain()
        {
            Type type = typeof(Student);

            Console.WriteLine("===== CONSTRUCTOR METADATA =====\n");

            // Get all constructors
            ConstructorInfo[] constructors = type.GetConstructors(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static);

            foreach (ConstructorInfo ctor in constructors)
            {
                Console.WriteLine("Constructor Name : " + ctor.Name);
                Console.WriteLine("IsPublic         : " + ctor.IsPublic);
                Console.WriteLine("IsPrivate        : " + ctor.IsPrivate);
                Console.WriteLine("IsStatic         : " + ctor.IsStatic);
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n===== CONSTRUCTOR EXECUTION =====\n");

            // Invoke public constructor (int, string)
            ConstructorInfo publicCtor =
                type.GetConstructor(new Type[] { typeof(int), typeof(string) });

            object student1 = publicCtor.Invoke(new object[] { 101, "Aanand" });
            Console.WriteLine("Public Constructor Invoked");

            // Invoke private constructor (int)
            ConstructorInfo privateCtor =
                type.GetConstructor(
                    BindingFlags.NonPublic | BindingFlags.Instance,
                    null,
                    new Type[] { typeof(int) },
                    null);

            object student2 = privateCtor.Invoke(new object[] { 999 });
            Console.WriteLine("Private Constructor Invoked");

            Console.WriteLine("\n===== CONSTRUCTOR PARAMETERS =====\n");

            // GetParameters()
            ParameterInfo[] parameters = publicCtor.GetParameters();
            foreach (ParameterInfo p in parameters)
            {
                Console.WriteLine(p.ParameterType + " " + p.Name);
            }

        }
    }
}
