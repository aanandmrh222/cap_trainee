using System;

namespace Day03
{
    public class Wallet
    {
        private double money;
        // Constructor: runs automatically when a Wallet object is created 
        // 'amount' is the initial money given to the wallet
        public Wallet(double amount)
        {
            money = amount;
        }

        public void AddMoney(double amount)
        {
            if(amount > 0)
            {
                money += amount;
                Console.WriteLine("Money is added " + amount);
            } else Console.WriteLine("Invalid amount");
        }

        public double GetBalance()
        {
            return money;
        }
    }
}