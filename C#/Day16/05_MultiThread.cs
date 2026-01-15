using System;
using System.Threading;

class MultiThread
{
    static int counter = 0;
    static object lockObj = new object();


    public static void MultiThreadM()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final Counter Value: " + counter);
    }

    static void Increment()
    {
        for (int i = 0; i < 5; i++)
        {
            // counter++;
            // Console.WriteLine($"Counter: {counter} | Thread: {Thread.CurrentThread.ManagedThreadId}");

            lock(lockObj)
            {
                counter++;
            }
        }
    }
}
