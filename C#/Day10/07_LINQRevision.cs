using System;
using System.Collections.Generic;
using System.Linq;

// class Student
// {
//     static string name, grade;
//     static int marks;

// }

class LinqRev
{
    public static void LinqRevM(string[] args)
    {
        List<int> num = new List<int> {10,20,30};
        int first = num.First();
        Console.WriteLine(first);

        int res = num.First(n=>n>5);
        Console.WriteLine(res);


        int last = num.Last();
        Console.WriteLine(last);

        int resLast = num.First(n=>n>5);
        Console.WriteLine(resLast);
    }
    
}


/*

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // ===============================
        // SOURCE
        // ===============================
        // Initial data source
        List<Student> students = new List<Student>
        {
            new Student { Name = "Amit",  Marks = 75, Grade = "A" },
            new Student { Name = "Rahul", Marks = 82, Grade = "A" },
            new Student { Name = "Neha",  Marks = 55, Grade = "B" },
            new Student { Name = "Amit",  Marks = 90, Grade = "A" },
            new Student { Name = "Kiran", Marks = 68, Grade = "B" }
        };

        // ===============================
        // LINQ PIPELINE (PRECEDENCE FLOW)
        // ===============================

        var result =
            students

            // 1️⃣ WHERE → FILTER
            // Keeps only students with Marks > 60
            .Where(s => s.Marks > 60)

            // 2️⃣ SELECT → TRANSFORM / PROJECT
            // Select only required fields
            .Select(s => new
            {
                s.Name,
                s.Grade
            })

            // 3️⃣ DISTINCT → REMOVE DUPLICATES
            // Removes duplicate Name + Grade combinations
            .Distinct()

            // 4️⃣ ORDERBY → SORTING
            // Sorts alphabetically by Name
            .OrderBy(s => s.Name)

            // 5️⃣ TAKE → LIMIT RESULTS
            // Takes only first 3 records
            .Take(3)

            // 6️⃣ TOLIST → EXECUTION / MATERIALIZATION
            // Executes the query and stores result in memory
            .ToList();

        // ===============================
        // OUTPUT
        // ===============================
        Console.WriteLine("Final Result:");
        foreach (var item in result)
        {
            Console.WriteLine($"Name: {item.Name}, Grade: {item.Grade}");
        }

        // ===============================
        // TERMINAL OPERATORS EXAMPLES
        // ===============================

        // ANY → returns true/false
        bool anyFail = students.Any(s => s.Marks < 40);
        Console.WriteLine($"\nAny student failed? {anyFail}");

        // FIRST → returns first matching element
        var firstTopper = students
            .Where(s => s.Marks > 80)
            .First();
        Console.WriteLine($"First Topper: {firstTopper.Name}");

        // AGGREGATE → custom aggregation
        int totalMarks = students
            .Select(s => s.Marks)
            .Aggregate((a, b) => a + b);
        Console.WriteLine($"Total Marks: {totalMarks}");
    }
}

// ===============================
// SUPPORTING CLASS
// ===============================
class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public string Grade { get; set; }
}


*/