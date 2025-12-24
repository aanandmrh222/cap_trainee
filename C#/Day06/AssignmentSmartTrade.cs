using System;
using System.Collections.Generic;

// task 1
struct PriceSnapshot
{
    public string stockSymbol;
    public double stockPrice;

}

// task 2
abstract class Trade1 : System.Object
{
    public int tradeID { get; set; }
    public string stockSymbol { get; set; }
    public int quantity { get; set; }

    public abstract double TradeValueCalculator();

    public override string ToString()
    {
        return $"TradeId: {tradeID}, StockSymbol: {stockSymbol}, Quantity: {quantity}";
    }
}

// task 3
class EquityTrade : Trade1
{
    public double? marketPrice { get; set; }
    public override double TradeValueCalculator()
    {
        return quantity*(marketPrice ?? 0);
    }
}

// task 4
class TradeRepository<T> where T : Trade1
{
    private List<T> trades = new List<T>();
    // public static int totalTradeCounter {get; private set; }
    public void AddTrade(T trade)
    {
        trades.Add(trade);
        // totalTradeCounter++;
        TradeAnalytics.IncrementTradeCount();
    }
    public void DisplayTrades()
    {
        foreach(T trade in trades)
        {
            Console.WriteLine(trade.ToString());
        }
    }
}

// task 5
static class TradeAnalytics
{
    public static int totalTrades { get; private set; }
    public static void IncrementTradeCount()
    {
        totalTrades++;
    }
    public static void DisplayAnalytics()
    {
        Console.WriteLine($"Total Trades Executed: {totalTrades}");
    }
}

// task 6
static class FinancialExtensions
{
    public static double BrokerageCalculation(this double amount)
    {
        return amount * 0.01;
    }
    public static double GSTCalculation(this double amount)
    {
        return amount * 0.18;
    }
}


// task 7 
class TradeProcess
{
    public static void TradeProcessMethod(Trade1 trade)
    {
        switch(trade)
        {
            case EquityTrade equityTrade:
                Console.WriteLine("Processing Trade Type: EquityTrade");
                Console.WriteLine($"Trade Value: {equityTrade.TradeValueCalculator()}");
                break;

            default:
                Console.WriteLine("Processing Trade Type: Unknown Trade");
                break;
        }
    }
}
