/*

Recursion is a technique where a method calls itself to solve a problem by breaking it into smaller sub-problems.
---------- Basic Structure of Recursion
        Every recursive method has two parts:
    ✅Base Condition – stops recursion
    ✅Recursive Call – function calls itself

*/

using System;

class Recursion
{
    public static int Factorial(int n)
    {
        if (n == 1)        // Base case
            return 1;
        return n * Factorial(n - 1); // Recursive call
    }

    // Fibonacci Series
    public static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Sum of Numbers
    public static int Sum(int n)
    {
        if (n == 0)
            return 0;
        return n + Sum(n - 1);
    }

    // Power Calculation
    public static int Power(int baseNum, int exp)
    {
        if (exp == 0)
            return 1;
        return baseNum * Power(baseNum, exp - 1);
    }

}


class RecursionCaller
{
    public static void RecursionCallerMethod()
    {
        int res = Recursion.Factorial(5);
        Console.WriteLine($"Factorial of 5 is: {res}");

        int res2 = Recursion.Fibonacci(5);
        Console.WriteLine($"Fibonacci of 5 is: {res2}");

        int res3 = Recursion.Sum(5);
        Console.WriteLine($"Sum of 5 is: {res3}");

        int res4 = Recursion.Power(5,3);
        Console.WriteLine($"Power of 5^3 is: {res4}");
    }
}