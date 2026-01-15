using System;
using System.Diagnostics;


class GetCurrentProcess
{
    public static void GetCurrentProcessM ()
    {
        Process currentProcess = Process.GetCurrentProcess();
        Console.WriteLine("Start time: " + currentProcess.StartTime);
        Console.WriteLine("TOtal Process time: " + currentProcess.TotalProcessorTime);
        Console.WriteLine("Current process id: " + currentProcess.Id);
        Console.WriteLine("Process name: " + currentProcess.ProcessName);
        Console.WriteLine("Thread: " + currentProcess.Threads);

    }
}