using System;
namespace Day01
{
    public class Questions
    {
        public static void SecToMin()
        {
            Console.Write("Enter the value of sec: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            int min = sec/60;
            Console.WriteLine(min);
        }


        public static int SumOfDigit(int num)
        {
            int sum = 0;
            while(num>0)
            {
                sum +=  num % 10;
                num /= 10;
            }
            return sum;
        }


        public static int ReverseNum(int num)
        {
            int sum = 0;
            while(num>0)
            {
                int a = num % 10;
                sum = sum *10 + a;
                num /= 10;
            }
            return sum;
        }
    }
}