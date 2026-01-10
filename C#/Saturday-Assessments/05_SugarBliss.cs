using System;

class Chocolate
{
    public string Flavour;
    public int Quantity;
    public int PricePerUnit;
    public double TotalPrice;
    public double DiscountedPrice;
    public bool ValidateChocolateFlavour()
    {
        if(Flavour == "Dark" || Flavour == "Milk" || Flavour=="White")
        {
            return true;
        }
        return false;
    }
}


class ChocolateMain
{
    public static Chocolate CalculateDiscountedPrice(Chocolate chocolate)
    {
        int DarkDis = 18;
        int MilkDis = 12;
        int WhiteDis = 6;

        chocolate.TotalPrice = chocolate.Quantity*chocolate.PricePerUnit;

        if(chocolate.Flavour == "Dark")
        {
            chocolate.DiscountedPrice = chocolate.TotalPrice - (chocolate.TotalPrice*DarkDis/100);
        }
        else if(chocolate.Flavour == "Milk")
        {
            chocolate.DiscountedPrice = chocolate.TotalPrice - (chocolate.TotalPrice*MilkDis/100);
        }
        else if(chocolate.Flavour == "White")
        {
            chocolate.DiscountedPrice = chocolate.TotalPrice - (chocolate.TotalPrice*WhiteDis/100);
        }

        return chocolate;
    }


    public static void ChocolateMainCallerMethod()
    {
        Chocolate chocolate = new Chocolate();

        Console.WriteLine("Enter the flavour: ");
        chocolate.Flavour = Console.ReadLine();
        
        Console.WriteLine("Enter the quantity: ");
        chocolate.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the price per unit: ");
        chocolate.PricePerUnit = Convert.ToInt32(Console.ReadLine());

        if(!chocolate.ValidateChocolateFlavour())
        {
            Console.WriteLine("Invalid flavour");
        } 
        else
        {
            CalculateDiscountedPrice(chocolate);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Flavour : " + chocolate.Flavour);
            Console.WriteLine("Quantity : " + chocolate.Quantity);
            Console.WriteLine("Price Per Unit : " + chocolate.PricePerUnit);
            Console.WriteLine("Total Price : " + chocolate.TotalPrice);
            Console.WriteLine("Discounted Price : " + chocolate.DiscountedPrice);

        }
    }
}