using System;

public class SaleTransaction
{
    public string InvoiceNo;
    public string CustomerName;
    public string ItemName;
    public int Quantity;
    public double PurchaseAmount;
    public double SellingAmount;
    public string ProfitOrLossStatus;
    public double ProfitOrLossAmount;
    public double ProfitMarginPercent;

    public static SaleTransaction LastTransaction=null;
    public static bool HasLastTransaction=false;


    public static void CreateMethod()
    {
        SaleTransaction saleTransaction = new SaleTransaction();

        Console.Write("Enter Invoice No: ");
        saleTransaction.InvoiceNo = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(saleTransaction.InvoiceNo))
        {
            Console.WriteLine("Invoice number cannot be empty");
            return;
        }

        Console.Write("Enter Customer Name: ");
        saleTransaction.CustomerName = Console.ReadLine();

        Console.Write("Enter Item Name: ");
        saleTransaction.ItemName = Console.ReadLine();

        Console.Write("Enter Quantity of item: ");
        saleTransaction.Quantity = Convert.ToInt32(Console.ReadLine());
        if(saleTransaction.Quantity < 0)
        {
            Console.WriteLine("Please enter the valid quantity");
            return;
        }

        Console.Write("Enter Purchase Amount (total): ");
        saleTransaction.PurchaseAmount = Convert.ToDouble(Console.ReadLine());
        if(saleTransaction.PurchaseAmount < 0)
        {
            Console.WriteLine("Please enter the valid Purchase Amount");
            return;
        }

        Console.Write("Enter Selling Amount (total): ");
        saleTransaction.SellingAmount = Convert.ToDouble(Console.ReadLine());
        if(saleTransaction.SellingAmount <= 0)
        {
            Console.WriteLine("Please enter the valid Selling Amount");
            return;
        }

        CalculationMethod(saleTransaction);

        LastTransaction = saleTransaction;
        HasLastTransaction = true;

        Console.WriteLine("Transaction saved successfully.");
        Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount: " + Math.Round(LastTransaction.ProfitOrLossAmount,2));
        Console.WriteLine("Profit Margin (%): " + Math.Round(LastTransaction.ProfitMarginPercent, 2));

    } 

    public static void CalculationMethod(SaleTransaction saleTransaction)
    {
        saleTransaction.ProfitOrLossAmount = saleTransaction.SellingAmount - saleTransaction.PurchaseAmount;

        saleTransaction.ProfitMarginPercent = (saleTransaction.ProfitOrLossAmount / saleTransaction.PurchaseAmount) * 100;

        if(saleTransaction.ProfitOrLossAmount > 0)
        {
            saleTransaction.ProfitOrLossStatus = "Profit";
        } else if (saleTransaction.ProfitOrLossAmount < 0) {
            saleTransaction.ProfitOrLossStatus = "Loss";
        } else
        {
            saleTransaction.ProfitOrLossStatus = "BREAK-EVEN";
        }
    }

    public static void ViewMethod()
    {
        if(!HasLastTransaction)
        {
            Console.WriteLine("You don't have last transaction, please create first");
            return;
        }

        Console.WriteLine("-------------- Last Transaction --------------");
        Console.WriteLine("InvoiceNo: " + LastTransaction.InvoiceNo);
        Console.WriteLine("Customer: " + LastTransaction.CustomerName);
        Console.WriteLine("Item: " + LastTransaction.ItemName);
        Console.WriteLine("Quantity: " + LastTransaction.Quantity);
        Console.WriteLine("Purchase Amount: " + Math.Round(LastTransaction.PurchaseAmount, 2));
        Console.WriteLine("Selling Amount: " + Math.Round(LastTransaction.SellingAmount, 2));
        Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount: " + Math.Round(LastTransaction.ProfitOrLossAmount, 2));
        Console.WriteLine("Profit Margin (%): " + Math.Round(LastTransaction.ProfitMarginPercent, 2));
    }


    public static void QuickMartCallerM()
    {
        bool running = true;
        while(running)
        {
            Console.WriteLine("================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your option: ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {
                case 1:
                SaleTransaction.CreateMethod();
                break;

                case 2:
                SaleTransaction.ViewMethod();
                break;

                case 3:
                if(HasLastTransaction)
                {
                    CalculationMethod(LastTransaction);
                    Console.WriteLine("Profit/Loss recalculated.");
                } else
                    {
                        Console.WriteLine("No transaction available");
                    }
                break;

                case 4:
                running = false;
                break;

            }
        }
    }
}