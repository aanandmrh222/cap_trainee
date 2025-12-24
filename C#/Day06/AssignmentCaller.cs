using System;

class AssignmentCaller
{
    public static void AssignmentCallerMethod()
    {
        // Task 1
        PriceSnapshot snapshot = new PriceSnapshot
        {
            stockSymbol = "TCS",
            stockPrice = 100.65
        };
        Console.WriteLine("Market Price Snapshot:");
        Console.WriteLine($"Stock Symbol: {snapshot.stockSymbol}");
        Console.WriteLine($"Stock Price : {snapshot.stockPrice}");

        
        // Task 3
        EquityTrade tradeWithPrice  = new EquityTrade
        {
            tradeID = 1001,
            stockSymbol = "TCS 2",
            quantity = 5,
            marketPrice = 15.5
        };
        Console.WriteLine("Trade Value with price " + tradeWithPrice.TradeValueCalculator());

        EquityTrade tradeWithoutPrice  = new EquityTrade
        {
            tradeID = 1001,
            stockSymbol = "TCS 2",
            quantity = 5,
            marketPrice = null
        };
        Console.WriteLine("Trade Value without price " + tradeWithoutPrice.TradeValueCalculator());


        // Task 4
        TradeRepository<EquityTrade> repo = new TradeRepository<EquityTrade>();
        EquityTrade trade1 = new EquityTrade
        {
            tradeID = 2001,
            stockSymbol = "2001ASD",
            quantity = 20,
            marketPrice = 15.6
        };
        EquityTrade trade2 = new EquityTrade
        {
            tradeID = 3001,
            stockSymbol = "3001ASD",
            quantity = 30,
            marketPrice = 20.6
        };
        repo.AddTrade(trade1);
        repo.AddTrade(trade2);
        Console.WriteLine("+++++++++++ Repo Contents ++++++++++++++++");
        repo.DisplayTrades();
        // Console.WriteLine("🚀 Total no of trades added: " + TradeRepository<EquityTrade>.totalTradeCounter);

        // task 5
        TradeAnalytics.DisplayAnalytics();

        // task 6
        // double tradeValue = trade1.TradeValueCalculator();
        // double brokerageValue = tradeValue.BrokerageCalculation();
        // double GSTValue = tradeValue.GSTCalculation();
        // Console.WriteLine($"Brokerage Value  : {brokerageValue}");
        // Console.WriteLine($"GST VAlue: {GSTValue}");


        // task 7
        TradeProcess.TradeProcessMethod(trade1);

    }
}