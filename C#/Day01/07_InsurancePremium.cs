using System;

class InsurancePremium
{
    public static void InsurancePremiumCallerMethod()
    {
        Console.WriteLine("\n--- Insurance Premium & Claim System ---");

        Console.Write("Enter Customer Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Is Policy Active? (yes/no): ");
        string policy = Console.ReadLine().ToLower();

        Console.Write("Enter number of months paid: ");
        int months = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Coverage Amount: ");
        double coverage = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Claim Amount: ");
        double claim = Convert.ToDouble(Console.ReadLine());

        // Premium Calculation
        double premium = 0;
        if(age >= 18 && age <=30) {
            premium = 1200;
        } else if(age > 30 && age <=50)
        {
            premium = 1200;
        } else if(age > 50 && age <=60)
        {
            premium = 2500;
        } else
        {
            premium = 3000;
        }

        // Claim Eligibility
        string claimStatus = (policy == "yes" && months >= 6 && claim < coverage) ? "APPROVED": "REJECTED";



        Console.WriteLine("\n--- Customer Insurance Report ---");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Monthly Premium: ₹{premium}");
        Console.WriteLine($"Coverage: ₹{coverage}");
        Console.WriteLine($"Claim Amount: ₹{claim}");
        Console.WriteLine($"Claim Status: {claimStatus}");

    }
}