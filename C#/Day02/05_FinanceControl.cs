using System;
namespace Day02
{
    public class FinanceControl
    {
        public static void CallingMethod()
        {
            bool run = true;
            while(run)
            {
                Console.WriteLine("--- Finance Control System ---");
                Console.WriteLine("1. Check Loan Eligibility");
                Console.WriteLine("2. Calculate Tax");
                Console.WriteLine("3. Enter Transactions");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        CheckLoanEligibility();
                        break;

                    case 2:
                        CalculateTax();
                        break;

                    case 3:
                        EnterTransactions();
                        break;

                    case 4:
                        Console.WriteLine("Program Exited");
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        public static void CheckLoanEligibility()
        {
            Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Monthly Income: ");
            int income = Convert.ToInt32(Console.ReadLine());

            if(age>=21 && income>=30000)
            {
                Console.WriteLine("Loan Approved");
            } else
            {
                Console.WriteLine("Loan Reaject");
            }

        }

        public static void CalculateTax()
        {
            Console.Write("Enter Annual Income: ");
            double income = Convert.ToDouble(Console.ReadLine());
            double tax;

            if (income <= 250000)
            {
                tax = 0;
            }
            else if (income <= 500000)
            {
                tax = income * 0.05;
            }
            else if (income <= 1000000)
            {
                tax = income * 0.20;
            }
            else
            {
                tax = income * 0.30;
            }
            Console.WriteLine($"Tax Payable: {tax}");
        }

        public static void EnterTransactions()
        {
            double total = 0;
            int validCount = 0;

            Console.WriteLine("Enter 5 Transactions:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Transaction {i}: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount < 0)
                {
                    Console.WriteLine("Invalid transaction skipped");
                    continue;
                }
                total += amount;
                validCount++;
            }

            Console.WriteLine($"Total number of transactions: {validCount}");
            Console.WriteLine($"Sum of all the transactions: {total}");
        
        }
    }
}