using System;
namespace Day01
{
    public class Basic2
    {
        public static void BasicMethod2()
        {
            int age = 555;
            if (age >= 5 && age < 18)
            {
                Console.WriteLine("You are under 18");
            }
            else if (age >= 18 && age < 60)
            {
                Console.WriteLine("You are ubder 18-60");
            }
            else
            {
                Console.WriteLine("You are above 60");
            }


            int age1 = 22;
            bool hasLicense = true;

            if (age1 >= 18)
            {
                if (hasLicense)
                {
                    Console.WriteLine("You are allowed to drive");
                }
                else
                {
                    Console.WriteLine("License required");
                }
            }
            else
            {
                Console.WriteLine("You under 18");
            }
        }
    }
}