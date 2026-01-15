using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        // Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
        // thread.Start("Hello from thread");


        // Thread worker = new Thread(DoWork);
        // worker.Start();
        // Console.WriteLine("Main thread continues....");


        // Parallel.For(0, 5, i =>
        // {
        //     Console.WriteLine($"Processing item {i}");
        // }); 

        // ThreadClass.ThreadClassM();

        // await AsyncFile.AsyncFileM();

        // GetCurrentProcess.GetCurrentProcessM();

        // JoinMet.JoinMetM();
        
        // Process.Start("notepad.exe");

        // MultiThread.MultiThreadM();

        // AggregateExcep.AggregateExcepM();

        // Task t1 = Task.Run(()=>Console.WriteLine("Task 1"));
        // Task t2 = Task.Run(()=>Console.WriteLine("Task 2"));

        // Task.WhenAll(t1,t2).ContinueWith(t => Console.WriteLine("All tasks completed"));
        // Console.ReadLine();


        Task<int> t = Task.Run(()=>42);
        Console.WriteLine(t.Result);
        t.ContinueWith((resTask) => Console.WriteLine("result: " + resTask.Result));
        Console.ReadLine();
    }


    static void PrintMessage(object message)
    {
        Console.WriteLine(message);
    }

    static void DoWork()
    {
        Console.WriteLine("Befor");
        for(int i=1;i<=5; i++)
        {
            Console.WriteLine("Worker thread : " + i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("After");
    }
}