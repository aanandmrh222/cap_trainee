/*
Each object contains:
Properties → Data (Fields)
Actions → Behavior (Methods)
*/


using System;

namespace Day03
{
    public class BankAccount
    {
        public int accNum;
        public double balance;

        public void Deposit(double amount)
        {
            balance += amount;
        }
        
    }

    public class Employee
    {
        // Means: name is allowed to be null --> string?
        public string? name;
        public double salary;

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee {name} earns {salary}");
        }
    }
}