using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

class ThreadClass
{
    public static void ThreadClassM()
    {
        int[] numbers = new int[10];

        for(int i=0; i<numbers.Length; i++)
        {
            numbers[i] = i+1;
        }

        // Console.WriteLine(string.Join(" ", numbers));

        int sum = 0;
        
        // Parallel.For(0, numbers.Length, i=>
        // {
        //     sum += numbers[i];   // Not thread-safe (for demostration)
        // });

        // Console.WriteLine("Sum: " + sum);

        Parallel.For(
            0,
            numbers.Length,
            () => 0,       // Thread-local initialization
            (i, loopState, localSum) =>
            {
                return localSum + numbers[i];
            },
            localSum =>
            {
                Interlocked.Add(ref sum, localSum);
            }
        );

        Console.WriteLine("Sum: " + sum);
    }
}