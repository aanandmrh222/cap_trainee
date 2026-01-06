// Action delegate has no return type
// use case -> logging, callback, async, event handler, pipelines

using System;

class ActionDelegate
{
    public static void ActionDelegateMethod()
    {
        Action<string> logActivity = mess => Console.WriteLine($"Log ENTRY: {mess}");

        logActivity($"User Logged at {DateTime.Now}");
    }
}