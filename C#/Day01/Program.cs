using System;
using Day01;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Welcome to C# programming!");

        // Console.Write("Enter your name: ");
        // string name = Console.ReadLine();

        // Console.Write("Enter your age: ");
        // int age = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Your name is " + name + " and age is " + age);
        // Console.WriteLine($"Your name is {name} and age is {age}");
        

        // Basic1.BasicMethod1();

        // Basic2.BasicMethod2();

        // AreaCircle.AreaCircleMethod();
        // FeetToCenti.FeetToCentiMethod();
        // LargestOfThreeNo.LargestOfThreeNoMethod();
        Questions.SecToMin();
        Console.WriteLine(Questions.SumOfDigit(765));
        Console.WriteLine(Questions.ReverseNum(765));
        
        InsurancePremium.InsurancePremiumCallerMethod();
    }
}