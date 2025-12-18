using System;
namespace Day01
{
    
    public class LargestOfThreeNo
    {
        public static void LargestOfThreeNoMethod()
        {
            Console.Write("Enter the 1st number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd number ");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a>b && a>c)
            {
            Console.Write($"{a} is grater");
            
            } else if(b>c)
            {
            Console.Write($"{b} is grater");
                
            } else
            {
            Console.Write($"{c} is grater");
                
            }
        }
    }
}