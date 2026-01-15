using System;
using System.Reflection;

namespace ReflectionMemberInfoDemo
{
    // ---------------- CUSTOM ATTRIBUTE ----------------
    [AttributeUsage(AttributeTargets.All)]
    public class InfoAttribute : Attribute
    {
        public string Description { get; }

        public InfoAttribute(string description)
        {
            Description = description;
        }
    }

    // ---------------- STUDENT CLASS ----------------
    [Info("Student Class")]
    public class Student
    {
        [Info("Student Id Field")]
        public int Id;

        [Info("Student Name Property")]
        public string Name { get; set; }

        [Info("Student Constructor")]
        public Student() { }

        [Info("Student Method")]
        public void Display() { }

        [Info("Student Event")]
        public event EventHandler StudentEvent;
    }

    class MemberInfoClass
    {
        public static void MemberInfoClassMain()
        {
            Type type = typeof(Student);

            Console.WriteLine("===== MEMBER INFO DETAILS =====\n");

            // Get all members
            MemberInfo[] members = type.GetMembers(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static);

            foreach (MemberInfo member in members)
            {
                Console.WriteLine("Name           : " + member.Name);
                Console.WriteLine("MemberType     : " + member.MemberType);
                Console.WriteLine("DeclaringType  : " + member.DeclaringType);

                // GetCustomAttributes()
                object[] attributes = member.GetCustomAttributes(false);
                Console.WriteLine("CustomAttributes Count: " + attributes.Length);

                foreach (object attr in attributes)
                {
                    Console.WriteLine(" - " + attr.GetType().Name);
                }

                // IsDefined(Type attributeType)
                bool hasInfoAttr = member.IsDefined(typeof(InfoAttribute), false);
                Console.WriteLine("Has InfoAttribute: " + hasInfoAttr);

                Console.WriteLine("----------------------------------");
            }

        }
    }
}
