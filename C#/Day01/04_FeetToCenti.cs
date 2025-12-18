using System;
namespace Day01
{
    public class FeetToCenti
    {
        public static void FeetToCentiMethod()
        {
            Console.Write("Enter the feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());

            double res = 30.48*feet;
            Console.WriteLine("Feet to Centi is " + res);

        }
    }
}