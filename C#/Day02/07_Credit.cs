using System;

namespace Day02
{
    
    public class Credit
    {
        public static void NetSalary()
        {
            Console.Write("Enter gross salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            double netSalary = salary - (salary * 0.10);
            Console.WriteLine($"Net salary credited: ₹{netSalary}");
        }

        public static void FixedDeposit()
        {
            Console.Write("Enter principal amount: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rate of interest: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter time (years): ");
            double t = Convert.ToDouble(Console.ReadLine());

            double interest = (p * r * t) / 100;
            double maturity = p + interest;

            Console.WriteLine($"Fixed Deposit maturity amount: ₹{maturity}");
        }

        public static void CreditCardRewardPoints()
        {
            Console.Write("Enter total credit card spending: ");
            int spending = Convert.ToInt32(Console.ReadLine());

            int points = spending / 100;
            Console.WriteLine($"Reward points earned: {points}");
        }

        public static void BonusEligibility()
        {
            Console.Write("Enter annual salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter years of service: ");
            int years = Convert.ToInt32(Console.ReadLine());

            if (salary >= 500000 && years >= 3)
            {
                Console.WriteLine("Employee is eligible for bonus.");
            }
            else
            {
                Console.WriteLine("Employee is not eligible for bonus.");
            }
        }
    }

}
