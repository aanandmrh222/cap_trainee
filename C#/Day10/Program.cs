// using System;

// class Program
// {
//     static void Main()
//     {

//         /*

//         // List<MyClass> list = new List<MyClass>();

//         Console.WriteLine("Creating objects...");
//         for(int i=0; i<5; i++)
//         {
//             MyClass obj = new MyClass();
//             // list.Add(new MyClass());
//         }
//         Console.WriteLine("Forcing garbage collection...");
//         GC.Collect();
//         GC.WaitForPendingFinalizers();

//         Console.WriteLine("Garbage collection completed");

//         // Console.WriteLine(string.Join(" ", list));





//         (int, string) st1 = (101, "Aanand");
//         var st2 = (Id : 101, Name: "Aanand");
//         Console.WriteLine(st1.GetType());
//         Console.WriteLine(st2.GetType());

//         var st3 = new
//         {
//             Id = 101,
//             Name = "Aanand",
//             Marks = 85
//         };
//         Console.WriteLine(st3.GetType());

//         // with the help of tuple we can return multiple value, if don't want tuple use out keyword
//         static (int sum, int avg) Cal(int a, int b)
//         {
//             return (a+b, (a+b)/2);
//         }

//         Console.WriteLine(Cal(2,6));


//         static (bool IsValid, string Message) ValidUser(string userName)
//         {
//             if(string.IsNullOrEmpty(userName))
//             {
//                 return (false, "USer  name is required");
//             }
//             return (true, "Valid USer");
//         }

//         var response = ValidUser("Aanand");
//         Console.WriteLine(response.Message);

        

//         // deconstructing a tuple 
//         var person = (Id : 1, Name : "Neha");   // creating a tuple
//         // Console.WriteLine(person.Id);

//         // var(id, name) = person;   // deconstruction
//         // Console.WriteLine(id);
//         // Console.WriteLine(name.GetType());

//         // using discard
//         var(_, userName) = person;   // _ means skip that value
//         Console.WriteLine(userName);
//         Console.WriteLine(userName.GetType());


//         int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

//         var evenNumbers = numbers.Where(n => n % 2 == 0);

//         Console.WriteLine(string.Join(" ", evenNumbers));
//         Console.WriteLine(evenNumbers.GetType());

//         var res = numbers.Where(n => n>3).Select(n=>n*2);
//         Console.WriteLine(string.Join(" ", res));
//         Console.WriteLine(res.GetType());

        
//         List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };

//         var ascending = numbers.OrderBy(n => n);
//         var descending = numbers.OrderByDescending(n => n);

//         Console.WriteLine("Ascending:");
//         foreach (var n in ascending)
//         {
//             Console.Write(n + " ");
//         }

//         Console.WriteLine("\nDescending:");
//         foreach (var n in descending)
//         {
//             Console.Write(n + " ");
//         }

//         */

        
//     }
// }


// // class MyClass
// // {
// //     ~MyClass()
// //     {
// //         Console.WriteLine("Finalized called, object collected");
// //     }
// // }




using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"Total Memory Before GC: {GC.GetTotalMemory(false)} bytes");

        for (int i = 0; i < 10000; i++)
        {
            object obj = new object(); // Gen 0 allocation
        }

        Console.WriteLine($"Total Memory After Object Creation: {GC.GetTotalMemory(false)} bytes");

        GC.Collect(); 
        GC.WaitForPendingFinalizers();

        Console.WriteLine($"Total Memory After GC: {GC.GetTotalMemory(false)} bytes");
        Console.WriteLine($"Generation of a new object: {GC.GetGeneration(new object())}");

        EnterpriseLogSystem.EnterpriseCaller.EnterpriseCallerMethod();
    }
}