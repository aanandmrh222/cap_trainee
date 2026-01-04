class LINQClass
{
    public void LINQClassM()
    {
        // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // var evenNumbers = numbers.Where(n => n % 2 == 0);

        // Console.WriteLine("Type of var evenNumber is ::>> " + (evenNumbers.GetType()));

        // Console.Write("All even numbers are ::>>   ");
        // foreach (var e in evenNumbers)
        // {
        //     Console.Write(e + "  ");
        // }

        // var grtThree = numbers.Where(n => n > 3).Select(n => n * 2);
        // Console.WriteLine("Type of var grtThree is ::>> " + (grtThree.GetType()));
        // Console.Write("All grtThree numbers are ::>>   ");
        // foreach (var e in grtThree)
        // {
        //     Console.Write(e + "  ");
        // }


        // Student1[] students =
        // {
        //     new Student1 { Name = "Aman", Grade = 'A', Marks = 75 },
        //     new Student1 { Name = "Ravi", Grade = 'B', Marks = 58 },
        //     new Student1 { Name = "Neha", Grade = 'A', Marks = 90 }
        // };

        // var result = students.Select(s => new
        // {
        //     s.Name,
        //     s.Grade,
        //     Result = s.Marks >= 60 ? "Pass" : "Fail"
        // });

        // Console.WriteLine("Type of result is ::>> "+(result.GetType()));
        // result = result.ToList();
        // Console.WriteLine("Type of result After ToList ::>> "+(result.GetType()));

        // foreach (var r in result)
        //     Console.WriteLine(r.Name + " " + r.Grade + " " + r.Result);



        List<int> numbers = new List<int> { 5, 2, 8, 1, 4, 3 };

        var ascending = numbers.OrderBy(n => n);

        var decending = numbers.OrderByDescending(n => n);

        Console.Write("\nAscending ::>> ");
        foreach (var n in ascending)
            Console.Write(n+"  ");


        Console.Write("\nDecending ::>> ");
        foreach (var n in decending)
            Console.Write(n+"  ");
            
    }
}

class Student1
{
    public string Name { get; set; }
    public char Grade { get; set; }
    public int Marks { get; set; }
}