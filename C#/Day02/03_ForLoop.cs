using System;
namespace Day02
{
    public class ForLoop
    {
        public static void TableMulti()
        {
            int a=20;
            int b=25;
            for(int i=a; i<=b; i++)
            {
                Console.WriteLine($"Table of {a}");
                for(int j=1; j<=10; j++)
                {
                    Console.WriteLine($"{a} * {j} = {a*j}");
                }
                a++;
                Console.WriteLine();
            }
        }
    }
}