using System;
using System.Reflection;

namespace ReflectionFieldInfoDemo
{
    // ---------------- STUDENT CLASS ----------------
    public class Student
    {
        public int Id;                 // public field
        private string Name;           // private field
        public static string College = "LPU"; // static field
        public readonly int Year = 2026;      // readonly field

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class FileInfoClass
    {
        public static void FileInfoClassMain()
        {
            Student student = new Student(101, "Aanand");

            // Get Type of Student
            Type type = typeof(Student);

            Console.WriteLine("===== FIELD METADATA =====\n");

            // Get all fields (public + private + static + instance)
            FieldInfo[] fields = type.GetFields(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static);

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine("Field Name       : " + field.Name);
                Console.WriteLine("Field Type       : " + field.FieldType);
                Console.WriteLine("IsPublic         : " + field.IsPublic);
                Console.WriteLine("IsPrivate        : " + field.IsPrivate);
                Console.WriteLine("IsStatic         : " + field.IsStatic);
                Console.WriteLine("IsInitOnly       : " + field.IsInitOnly);
                Console.WriteLine("DeclaringType    : " + field.DeclaringType);
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n===== FIELD VALUE ACCESS =====\n");

            // Get specific field
            FieldInfo idField = type.GetField("Id");
            FieldInfo nameField = type.GetField(
                "Name",
                BindingFlags.NonPublic | BindingFlags.Instance);

            // GetValue(object obj)
            Console.WriteLine("Before Change:");
            Console.WriteLine("Id   : " + idField.GetValue(student));
            Console.WriteLine("Name : " + nameField.GetValue(student));

            // SetValue(object obj, object value)
            idField.SetValue(student, 999);
            nameField.SetValue(student, "Kumar");

            Console.WriteLine("\nAfter Change:");
            Console.WriteLine("Id   : " + idField.GetValue(student));
            Console.WriteLine("Name : " + nameField.GetValue(student));

        }
    }
}
