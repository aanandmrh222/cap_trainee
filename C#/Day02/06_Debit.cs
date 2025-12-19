using System;

namespace Day02 
{
    public class Debit
    {
        public static void ATMWithdrawal()
        {
            Console.Write("Enter your withdraw amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if(amount <= 40000)
            {
                Console.WriteLine("Withdrawal permitted within daily limit.");
            } else
            {
                Console.WriteLine("Daily ATM withdrawal limit exceeded.");
            }
        }

        public static void EMIBurden()
        {
            Console.Write("Enter your monthly income: ");
            double monthlyIncome = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your EMI: ");
            double emi = Convert.ToDouble(Console.ReadLine());

            if(emi <= monthlyIncome*0.40)
            {
                Console.WriteLine("EMI is financially manageable.");
            } else
            {
                Console.WriteLine("EMI exceeds safe income limit.");
            }
        }

        public static void DailyBasedTransaction()
        {
            Console.Write("Enter your number of transaction: ");
            int noTransaction = Convert.ToInt32(Console.ReadLine());
            double totalAmountTransaction = 0;
            
            for(int i=1; i<=noTransaction; i++)
            {
                Console.Write($"Enter the {i}th amount: ");
                double currAmount = Convert.ToDouble(Console.ReadLine());
                totalAmountTransaction += currAmount;
            } 
            Console.WriteLine($"Total debit amount for the day: ₹{totalAmountTransaction}");
        }

        public static void MinimumBalanceCheck()
        {
            Console.Write("Enter your current balance: ");
            double currBalance = Convert.ToDouble(Console.ReadLine());
            
            if(currBalance < 2000)
            {
                Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
            } else
            {
                Console.WriteLine("Minimum balance requirement satisfied.");
            }
        }
    }
}