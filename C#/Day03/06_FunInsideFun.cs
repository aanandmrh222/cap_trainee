using System;

namespace Day03
{
    public class Calculator
    {
        public static void CalCu()
        {
            int a=6;
            int b=1;
            
            int add()
            {
                return a+b;
            }
            int sub()
            {
                return a-b;
            }

            Console.WriteLine($"Sum of {a} and {b} is: {a+b}");
            Console.WriteLine($"Difference of {a} and {b} is: {a-b}");
        }
    }
}