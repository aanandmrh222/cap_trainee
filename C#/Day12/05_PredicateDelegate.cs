// A Predicate Delegate represents a method that returns a boolean value and takes one Parameter. 
// Used for validation and filtering:


using System;

class PredicateDelegate
{
    public static void PredicateDelegateMethod()
    {
        Predicate<int> isEligible = age => age>=18;

        Console.WriteLine(isEligible(18));

    }
}