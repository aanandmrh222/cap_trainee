using System;
using System.Reflection;

namespace ReflectionTypeDemo
{
    // ---------------- STUDENT CLASS ----------------
    public class Student
    {
        public int Id;
        public string Name { get; set; }

        public Student() { }

        public Student(int id)
        {
            Id = id;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}");
        }

        public event EventHandler StudentEvent;

        public class InnerClass { }
    }

    // ---------------- TYPE DEMO CLASS ----------------
    class TypeClassCaller
    {
        public static void TypeClassCallerMain()
        {
            Console.WriteLine("===== TYPE RETRIEVAL =====\n");

            // 1. typeof(ClassName)
            Type t1 = typeof(Student);
            Console.WriteLine("typeof(Student): " + t1.FullName);

            // 2. object.GetType()
            Student s = new Student();
            Type t2 = s.GetType();
            Console.WriteLine("object.GetType(): " + t2.FullName);

            // 3. Type.GetType(string)
            Type t3 = Type.GetType("ReflectionTypeDemo.Student");
            Console.WriteLine("Type.GetType(): " + t3.FullName);

            Console.WriteLine("\n===== TYPE INFORMATION METHODS =====\n");

            // GetFields
            Console.WriteLine("GetFields:");
            foreach (FieldInfo f in t1.GetFields())
                Console.WriteLine(f.Name);

            // GetMethods
            Console.WriteLine("\nGetMethods:");
            foreach (MethodInfo m in t1.GetMethods())
                Console.WriteLine(m.Name);

            // GetProperties
            Console.WriteLine("\nGetProperties:");
            foreach (PropertyInfo p in t1.GetProperties())
                Console.WriteLine(p.Name);

            // GetConstructors
            Console.WriteLine("\nGetConstructors:");
            foreach (ConstructorInfo c in t1.GetConstructors())
                Console.WriteLine(c.ToString());

            // GetEvents
            Console.WriteLine("\nGetEvents:");
            foreach (EventInfo e in t1.GetEvents())
                Console.WriteLine(e.Name);

            // GetInterfaces
            Console.WriteLine("\nGetInterfaces:");
            foreach (Type i in t1.GetInterfaces())
                Console.WriteLine(i.Name);

            // GetNestedTypes
            Console.WriteLine("\nGetNestedTypes:");
            foreach (Type nt in t1.GetNestedTypes())
                Console.WriteLine(nt.Name);

            // GetMembers
            Console.WriteLine("\nGetMembers:");
            foreach (MemberInfo mi in t1.GetMembers())
                Console.WriteLine(mi.MemberType + " - " + mi.Name);

            Console.WriteLine("\n===== SPECIFIC MEMBER LOOKUP =====\n");

            // GetField(string name)
            FieldInfo field = t1.GetField("Id");
            Console.WriteLine("GetField(\"Id\"): " + field?.Name);

            // GetMethod(string name)
            MethodInfo method = t1.GetMethod("Display");
            Console.WriteLine("GetMethod(\"Display\"): " + method?.Name);

            // GetProperty(string name)
            PropertyInfo prop = t1.GetProperty("Name");
            Console.WriteLine("GetProperty(\"Name\"): " + prop?.Name);

            // GetConstructor(Type[] types)
            ConstructorInfo ctor = t1.GetConstructor(new Type[] { typeof(int) });
            Console.WriteLine("GetConstructor(int): " + ctor);

            // GetEvent(string name)
            EventInfo evt = t1.GetEvent("StudentEvent");
            Console.WriteLine("GetEvent(\"StudentEvent\"): " + evt?.Name);

            Console.WriteLine("\n===== TYPE CHECKING PROPERTIES =====\n");

            Console.WriteLine("IsClass: " + t1.IsClass);
            Console.WriteLine("IsInterface: " + t1.IsInterface);
            Console.WriteLine("IsAbstract: " + t1.IsAbstract);
            Console.WriteLine("IsSealed: " + t1.IsSealed);
            Console.WriteLine("IsEnum: " + t1.IsEnum);
            Console.WriteLine("IsValueType: " + t1.IsValueType);
            Console.WriteLine("IsGenericType: " + t1.IsGenericType);
            Console.WriteLine("IsPublic: " + t1.IsPublic);
            Console.WriteLine("IsNested: " + t1.IsNested);

            // IsSubclassOf(Type)
            Console.WriteLine("IsSubclassOf(Object): " +
                t1.IsSubclassOf(typeof(object)));

        }
    }
}
