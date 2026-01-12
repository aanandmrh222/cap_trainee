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