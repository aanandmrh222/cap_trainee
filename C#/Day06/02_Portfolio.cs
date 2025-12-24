using System;

public class Portfolio
{
    public string Name;

    // its override the Equals method to check the value not reference 
    public override bool Equals(object obj)
    {
        Portfolio p = obj as Portfolio;
        return p != null && p.Name == Name;
    }
}

public class Caller
{
    public static void CallerMeth()
    {
        Portfolio p1 = new Portfolio { Name = "Growth" };
        Portfolio p2 = new Portfolio { Name = "Growth" };

        Console.WriteLine(p1.Equals(p2));
        Console.WriteLine(p1);  
        Console.WriteLine(p2);  
        Console.WriteLine(p1==p2);  // false because p1 and p2 refer to different memory locations

        /*
        ✔ Equals() → value comparison
        ✔ == (for classes) → reference comparison
        */

    }
}

