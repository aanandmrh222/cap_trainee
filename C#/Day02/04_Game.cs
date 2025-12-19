using System;
namespace Day02
{
    public class Game
    {
        public static void GameMethod()
        {
            int n = 10;
            Console.WriteLine("Game Beggins");
            for(int i=1; i<=n; i++)
            {
                if(i==4)
                {
                Console.WriteLine($"e{i} is invisible, skipping e{i}");
                continue;
                }
                Console.WriteLine($"Player KIlled e{i}");
            }
            Console.WriteLine("Game End");
        }

        public static void GoTO()
        {
            int num = 1;

            start:
            Console.WriteLine(num);
            num++;

            if (num <= 5)
                goto start;
            
            Console.WriteLine(num);

        }
    }
}