using System;
using System.Reflection;

namespace ReflectionMethodInfoDemo
{
    // ---------------- STUDENT CLASS ----------------
    public class Student
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from Student");
        }

        private int Add(int a, int b)
        {
            return a + b;
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Static Method Called");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Virtual Method");
        }

        public abstract class BaseStudent
        {
            public abstract void AbstractMethod();
        }

        public T GenericMethod<T>(T value)
        {
            return value;
        }
    }

    class MethodInfoClass
    {
        public static void MethodInfoClassMain()
        {
            Student student = new Student();
            Type type = typeof(Student);

            Console.WriteLine("===== METHOD METADATA =====\n");

            // Get all methods
            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static);

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Method Name   : " + method.Name);
                Console.WriteLine("Return Type   : " + method.ReturnType);
                Console.WriteLine("IsPublic      : " + method.IsPublic);
                Console.WriteLine("IsPrivate     : " + method.IsPrivate);
                Console.WriteLine("IsStatic      : " + method.IsStatic);
                Console.WriteLine("IsVirtual     : " + method.IsVirtual);
                Console.WriteLine("IsAbstract    : " + method.IsAbstract);
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n===== METHOD EXECUTION & INSPECTION =====\n");

            // Invoke public method
            MethodInfo sayHelloMethod = type.GetMethod("SayHello");
            sayHelloMethod.Invoke(student, null);

            // Invoke private method
            MethodInfo addMethod = type.GetMethod(
                "Add",
                BindingFlags.NonPublic | BindingFlags.Instance);

            object result = addMethod.Invoke(student, new object[] { 10, 20 });
            Console.WriteLine("Private Add Result: " + result);

            // Invoke static method
            MethodInfo staticMethod = type.GetMethod("StaticMethod");
            staticMethod.Invoke(null, null);

            // GetParameters()
            Console.WriteLine("\nParameters of Add method:");
            ParameterInfo[] parameters = addMethod.GetParameters();
            foreach (ParameterInfo p in parameters)
            {
                Console.WriteLine(p.ParameterType + " " + p.Name);
            }

            // GetGenericArguments()
            MethodInfo genericMethod = type.GetMethod("GenericMethod");
            Type[] genericArgs = genericMethod.GetGenericArguments();

            Console.WriteLine("\nGeneric Arguments of GenericMethod:");
            foreach (Type t in genericArgs)
            {
                Console.WriteLine(t.Name);
            }

        }
    }
}
