using System;
using System.Reflection;

namespace ReflectionAttributeDemo
{
    // ---------------- CUSTOM ATTRIBUTE ----------------
    [AttributeUsage(AttributeTargets.Class |
                    AttributeTargets.Field |
                    AttributeTargets.Property |
                    AttributeTargets.Method,
                    Inherited = true)]
    public class InfoAttribute : Attribute
    {
        public string Description { get; }

        public InfoAttribute(string description)
        {
            Description = description;
        }
    }

    // ---------------- STUDENT CLASS ----------------
    [Info("This is Student class")]
    public class Student
    {
        [Info("Student Id Field")]
        public int Id;

        [Info("Student Name Property")]
        public string Name { get; set; }

        [Info("Student Display Method")]
        public void Display()
        {
            Console.WriteLine("Display Method");
        }
    }

    class AttributeClass
    {
        public static void AttributeClassMain()
        {
            Type type = typeof(Student);

            Console.WriteLine("===== ATTRIBUTE READING METHODS =====\n");

            // 1. GetCustomAttributes(Type type, bool inherit)
            Console.WriteLine("GetCustomAttributes (Class):");
            object[] classAttributes =
                type.GetCustomAttributes(typeof(InfoAttribute), true);

            foreach (InfoAttribute attr in classAttributes)
            {
                Console.WriteLine(attr.Description);
            }

            Console.WriteLine("\n----------------------------------\n");

            // 2. IsDefined(MemberInfo element, Type attributeType)
            Console.WriteLine("IsDefined Checks:");

            FieldInfo field = type.GetField("Id");
            Console.WriteLine("Id has InfoAttribute: " +
                Attribute.IsDefined(field, typeof(InfoAttribute)));

            PropertyInfo prop = type.GetProperty("Name");
            Console.WriteLine("Name has InfoAttribute: " +
                Attribute.IsDefined(prop, typeof(InfoAttribute)));

            MethodInfo method = type.GetMethod("Display");
            Console.WriteLine("Display has InfoAttribute: " +
                Attribute.IsDefined(method, typeof(InfoAttribute)));

            Console.WriteLine("\n----------------------------------\n");

            // 3. GetCustomAttribute<T>()
            Console.WriteLine("GetCustomAttribute<T>:");

            InfoAttribute classAttr =
                type.GetCustomAttribute<InfoAttribute>();
            Console.WriteLine("Class Attribute: " + classAttr.Description);

            InfoAttribute methodAttr =
                method.GetCustomAttribute<InfoAttribute>();
            Console.WriteLine("Method Attribute: " + methodAttr.Description);

        }
    }
}
