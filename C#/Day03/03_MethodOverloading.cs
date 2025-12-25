/*
Method Overloading -> multiple methods have the same name but different parameter lists within the same class.
Method OverRiding -> A derived (child) class provides a new implementation of a method that is already 
                    defined in its base (parent) class, using the same method signature and the override keyword.
                    When a child class changes the behavior of a method that it inherits from its parent class, using the same method name and parameters.
inside MathOps -> Same method name, different parameter list (type / count / order)
*/

using System;

namespace Day03
{
    public class MathOps
    {
        public int Add(int a, int b)
        {
            return a+b;
        }
        public int Add(int a, int b, int c)
        {
            return a+b+c;
        }
        // Default Arguments
        public double Add(double a, double b=10.1)
        {
            return a+b;
        }
    }
}