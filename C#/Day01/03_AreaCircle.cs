using System;
namespace Day01
{
    public class AreaCircle
    {
        public static void AreaCircleMethod()
        {
            Console.Write("Enter the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = 3.14 * radius * radius;

            Console.Write("Area of circle is " + area);

        }
    }
}