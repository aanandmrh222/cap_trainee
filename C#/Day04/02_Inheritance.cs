using System;

public class Bank
{
    public double amount;
    public Bank(double am)
    {
        amount = am;
    }

    public void Print()
    {
        Console.WriteLine(amount);
    }
}

    
// Fixed Deposit class that inherits from Bank
public class Deposite : Bank
{
    public int timePeriod;
    public Deposite() : base(10000)
    {
        timePeriod = 1; 
        {
            timePeriod = 1;
        }
    }
}
