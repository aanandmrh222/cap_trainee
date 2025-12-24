using System;
namespace Day06
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*

            Console.WriteLine("Day 06");
            // struct object → value type → copied to a new memory location
            StockPrice originalPrice = new StockPrice
            {
                symbol = "TCS",
                price = 100
            };

            StockPrice copyPrice = originalPrice;
            copyPrice.price = 150;

            Console.WriteLine("Original " + originalPrice.price); // 100
            Console.WriteLine("Copy " + copyPrice.price); // 150


            // class object → reference type → both variables refer to the same object
            Trade tr = new Trade
            {
                tradeID = 101,
                stockSymbol = "AAPL",
                quantity = 10
            };

            Trade tr2 = tr; // copying reference
            tr2.quantity = 20;  // changing value

            Console.WriteLine("Original trade q " + tr.quantity);  // 20
            Console.WriteLine("Copy trade q " + tr2.quantity);  // 20

            Caller.CallerMeth();
            // Calculator.CalculateMethod();

            */

            AssignmentCaller.AssignmentCallerMethod();
            
        }
    }
}
