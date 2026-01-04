using System;
using System.IO;

namespace BankingSystem
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message)
            : base(message)
        {
        }
    }

    public class BankOperationException : Exception
    {
        public BankOperationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("Account number cannot be null or empty.");

            if (initialBalance < 0)
                throw new ArgumentException("Initial balance cannot be negative.");

            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            try
            {
                if (amount <= 0)
                    throw new ArgumentException("Withdrawal amount must be greater than zero.");

                if (amount > Balance)
                    throw new InsufficientBalanceException(
                        $"Withdrawal failed. Available balance: {Balance}");

                Balance -= amount;
                Console.WriteLine($"Withdrawal successful. Updated balance: {Balance}");
            }
            catch (InsufficientBalanceException ex)
            {
                LogException(ex);
                throw;
            }
            catch (Exception ex)
            {
                LogException(ex);
                throw new BankOperationException(
                    "Unexpected error occurred during withdrawal.", ex);
            }
        }

        private void LogException(Exception ex)
        {
            string logMessage =
                $"Date: {DateTime.Now}\n" +
                $"Account Number: {AccountNumber}\n" +
                $"Exception: {ex}\n" +
                $"----------------------------------\n";

            File.AppendAllText("BankingErrors.log", logMessage);
        }
    }

    

    class BankingSystemCaller
    {
        public static void BankingSystemCallerM()
        {
            try
            {
                BankAccount account = new BankAccount("ACC12345", 5000);
                account.Withdraw(1000);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (BankOperationException ex)
            {
                Console.WriteLine("Bank Error: " + ex.Message);
                Console.WriteLine("Root Cause: " + ex.InnerException?.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }

            Console.WriteLine("Application execution completed safely.");
        }
    }
}
