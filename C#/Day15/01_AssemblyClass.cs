using System;
using System.Reflection;

namespace ReflectionAssemblyDemo
{
    // ---------------- STUDENT CLASS ----------------
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student Id: {Id}, Name: {Name}");
        }
    }

    // ---------------- ASSEMBLY CLASS ----------------
    public class Assembly
    {
        public static void Execute()
        {
            Console.WriteLine("===== ASSEMBLY LOADING METHODS =====\n");

            // 1. GetExecutingAssembly
            System.Reflection.Assembly executingAssembly =
                System.Reflection.Assembly.GetExecutingAssembly();
            Console.WriteLine("GetExecutingAssembly:");
            Console.WriteLine(executingAssembly.FullName + "\n");

            // 2. GetCallingAssembly
            System.Reflection.Assembly callingAssembly =
                System.Reflection.Assembly.GetCallingAssembly();
            Console.WriteLine("GetCallingAssembly:");
            Console.WriteLine(callingAssembly.FullName + "\n");

            // 3. GetEntryAssembly
            System.Reflection.Assembly entryAssembly =
                System.Reflection.Assembly.GetEntryAssembly();
            Console.WriteLine("GetEntryAssembly:");
            Console.WriteLine(entryAssembly.FullName + "\n");

            // 4. Assembly.Load(string assemblyName)
            System.Reflection.Assembly loadByName =
                System.Reflection.Assembly.Load(executingAssembly.GetName());
            Console.WriteLine("Assembly.Load:");
            Console.WriteLine(loadByName.FullName + "\n");

            // 5. Assembly.LoadFrom(string path)
            System.Reflection.Assembly loadFromPath =
                System.Reflection.Assembly.LoadFrom(executingAssembly.Location);
            Console.WriteLine("Assembly.LoadFrom:");
            Console.WriteLine(loadFromPath.FullName + "\n");

            // 6. Assembly.LoadFile(string path)
            System.Reflection.Assembly loadFile =
                System.Reflection.Assembly.LoadFile(executingAssembly.Location);
            Console.WriteLine("Assembly.LoadFile:");
            Console.WriteLine(loadFile.FullName + "\n");

            Console.WriteLine("===== ASSEMBLY INFORMATION METHODS =====\n");

            // GetTypes
            Console.WriteLine("GetTypes:");
            foreach (Type t in executingAssembly.GetTypes())
            {
                Console.WriteLine(t.FullName);
            }

            // GetExportedTypes
            Console.WriteLine("\nGetExportedTypes:");
            foreach (Type t in executingAssembly.GetExportedTypes())
            {
                Console.WriteLine(t.FullName);
            }

            // GetModules
            Console.WriteLine("\nGetModules:");
            foreach (Module m in executingAssembly.GetModules())
            {
                Console.WriteLine(m.Name);
            }

            // GetManifestResourceNames
            Console.WriteLine("\nGetManifestResourceNames:");
            foreach (string res in executingAssembly.GetManifestResourceNames())
            {
                Console.WriteLine(res);
            }

            // GetReferencedAssemblies
            Console.WriteLine("\nGetReferencedAssemblies:");
            foreach (AssemblyName an in executingAssembly.GetReferencedAssemblies())
            {
                Console.WriteLine(an.FullName);
            }

            // GetName
            Console.WriteLine("\nGetName:");
            AssemblyName asmName = executingAssembly.GetName();
            Console.WriteLine("Name: " + asmName.Name);
            Console.WriteLine("Version: " + asmName.Version);

            // GetCustomAttributes
            Console.WriteLine("\nGetCustomAttributes:");
            object[] attributes = executingAssembly.GetCustomAttributes(false);
            foreach (object attr in attributes)
            {
                Console.WriteLine(attr.GetType().Name);
            }
        }
    }

    // ---------------- MAIN METHOD ----------------
    class AssemblyClassCaller
    {
        public static void AssemblyClassCallerMain()
        {
            Student s = new Student
            {
                Id = 1,
                Name = "Aanand"
            };
            s.Print();

            Console.WriteLine("\n----------------------------------\n");

            Assembly.Execute();

        }
    }
}
