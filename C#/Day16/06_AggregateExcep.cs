using System;

class AggregateExcep
{
    public static void AggregateExcepM()
    {
        try
        {
            Task t = Task.Run(() => throw new Exception("Task error"));
            // Console.WriteLine(t);
        }
        catch (AggregateException ex)
        {
            
            Console.WriteLine(ex.InnerExceptions[0].Message);
        }
    }
}