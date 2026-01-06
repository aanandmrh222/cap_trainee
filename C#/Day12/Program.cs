using System;

class Program
{
    static void Main()
    {
        // DelegateCaller.DelegateCallerMethod();

        // MultiDelegateCaller.MultiDelegateCallerMethod();

        // ActionDelegate.ActionDelegateMethod();

        // FuncDelegate.FuncDelegateMethod();

        // PredicateDelegate.PredicateDelegateMethod();

        // AnonDelegate.AnonDelegateMethod();

        // ButtonCaller.ButtonCallerMethod();

        // SmartHomeSecurity.SmartHomeSecurityCaller.SmartHomeSecurityCallerMethod();

        // CallbackDemo.CallbackDemoCaller.CallbackDemoCallerMethod();

        Comparison<int> sortDescending = (a,b) => b.CompareTo(a);
        Console.WriteLine(sortDescending(5,10));
        Console.WriteLine(sortDescending(10,5));
        Console.WriteLine(sortDescending(5,5));
        
    }
}