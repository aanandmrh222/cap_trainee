using System;
using System.Diagnostics;

class Debugger
{
    public static void DebuggerM()
    {
        Trace.Listeners.Add(new ConsoleTraceListener());
        Trace.WriteLine("Application started");

        int a = 10;
        int b = 0;

        try
        {
            int result = a / b;
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Trace.WriteLine("Exception occurred: " + ex.Message);
        }

        Trace.WriteLine("Application ended");

    }
}
