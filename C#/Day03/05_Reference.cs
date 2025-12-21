using System;


class Reference
{
    public void runProgram()
    {
        Console.WriteLine("\nExample of 'ref' ");
        int x = 10;
        Console.WriteLine($"Value of x before ref parameter is called ::>> {x}");
        IncByTen(ref x);
        Console.WriteLine($"Value of x after ref parameter is called ::>> {x}");


        Console.WriteLine("\n\nExample of 'out' ");
        int q, r;   // no initialization required
        Divide(10, 3, out q, out r);
        Console.WriteLine("Quotient = " + q);
        Console.WriteLine("Remainder = " + r);


        Console.WriteLine("\n\nAnother example of 'out' ");
        string result;
        GetResult(75, out result);
        Console.WriteLine(result);


        int num = 50;
        Print(in num);


    }

    void IncByTen(ref int a)
    {
        a += 10;
    }

    public static void Divide(int a, int b, out int quotient, out int remainder)
    {
        quotient = a / b;
        remainder = a % b;
    }


    public static void GetResult(int marks, out string grade)
    {
        if (marks >= 60)
            grade = "Pass";
        else
            grade = "Fail";
    }

    void Print(in int x)
    {
        Console.WriteLine(x);
    }


}