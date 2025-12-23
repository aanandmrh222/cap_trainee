using System;

class BankAccount
{
    // Encapsulation (private fields)
    private int accountNo;
    private double balance;

    // Static Field
    public static string BankName = "ABC National Bank";

    // Constructor
    public BankAccount(int accNo, double initialBalance)
    {
        accountNo = accNo;
        balance = initialBalance;
    }

    // Method Overloading - Deposit
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Amount deposited successfully.");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Overloaded Deposit using ref
    public void Deposit(ref double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            amount = 0; // cleared after deposit
            Console.WriteLine("Amount deposited using ref.");
        }
    }

    // Withdraw using out
    public bool Withdraw(double amount, out string message)
    {
        if (amount <= 0)
        {
            message = "Invalid withdrawal amount.";
            return false;
        }

        if (amount > balance)
        {
            message = "Insufficient balance.";
            return false;
        }

        balance -= amount;
        message = "Withdrawal successful.";
        return true;
    }

    // Display Account Details
    public void Display()
    {
        Console.WriteLine("---------------");
        Console.WriteLine($"Bank Name  : {BankName}");
        Console.WriteLine($"Account No : {accountNo}");
        Console.WriteLine($"Balance    : ₹{balance}");
        Console.WriteLine("---------------");
    }
}
