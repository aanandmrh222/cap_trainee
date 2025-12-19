using System;
namespace Day02
{
    public class WhileLoop
    {
        public static void Counter()
        {
            int a = 1;
            while(a <= 5)
            {
                Console.Write(a + " ");
                a++;
            }
            Console.WriteLine();
        }


        public static void RevCounter()
        {
            int a = 5;
            while(a > 0)
            {
                Console.Write(a + " ");
                a--;
            }
            Console.WriteLine();
        }
    }
}