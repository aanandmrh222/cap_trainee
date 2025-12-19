using System;

namespace Day02
{
    
    public class CreditDebit
    {
        public static void CallingMethod()
        {
            bool run = true;

            while (run)
            {
                Console.WriteLine("--- Finance Management System ---");
                Console.WriteLine("1. Debit Operations");
                Console.WriteLine("2. Credit Operations");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nDebit Menu");
                        Console.WriteLine("1. ATM Withdrawal");
                        Console.WriteLine("2. EMI Evaluation");
                        Console.WriteLine("3. Daily Spending");
                        Console.WriteLine("4. Minimum Balance Check");
                        Console.WriteLine("5. Exit");
                        Console.Write("Enter option: ");

                        int d = Convert.ToInt32(Console.ReadLine());

                        switch (d)
                        {
                            case 1: Debit.ATMWithdrawal(); break;
                            case 2: Debit.EMIBurden(); break;
                            case 3: Debit.DailyBasedTransaction(); break;
                            case 4: Debit.MinimumBalanceCheck(); break;
                            case 5: run = false; Console.WriteLine("Exiting Program"); break;
                            default: Console.WriteLine("Invalid Debit Option"); break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nCredit Menu");
                        Console.WriteLine("1. Net Salary");
                        Console.WriteLine("2. Fixed Deposit");
                        Console.WriteLine("3. Reward Points");
                        Console.WriteLine("4. Bonus Eligibility");
                        Console.WriteLine("5. Exit");
                        Console.Write("Enter option: ");

                        int c = Convert.ToInt32(Console.ReadLine());

                        switch (c)
                        {
                            case 1: Credit.NetSalary(); break;
                            case 2: Credit.FixedDeposit(); break;
                            case 3: Credit.CreditCardRewardPoints(); break;
                            case 4: Credit.BonusEligibility(); break;
                            case 5: run = false;  Console.WriteLine("Exiting Program"); break;
                            default: Console.WriteLine("Invalid Credit Option"); break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exiting Program");
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }

}