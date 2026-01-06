// A Func Delegate represents a method that returns a value. The last type parameter is always the return type.
// use case -> it use to quick one liner calculation

using System;

class FuncDelegate
{
    public static void FuncDelegateMethod()
    {
        Func<decimal, decimal, decimal> calculateDiscount 
        = (price, discount) => price - (price*discount/100);

        Console.WriteLine(calculateDiscount(100,10));

    }
}