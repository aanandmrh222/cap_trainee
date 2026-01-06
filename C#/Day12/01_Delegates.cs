// A delegate is a type-safe function pointer that:
    // Holds reference to a method
    // Invokes methods indirectly
    // Enables callback mechanisms
// Delegates -> pass callback method as parameter 


using System;

delegate void PaymentDelegate(decimal amount);

class PaymentService
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} processed successfully");
    }
}


static class PaymentExtensions
{
    public static bool isValidPayment(this decimal amount)    // we are using this keyword to direct access of method with help of varibale name is is called extension 
    {
        return amount >0 && amount <=1_000_000;
    }
}

class DelegateCaller
{
    public static void DelegateCallerMethod()
    {
        PaymentService service = new PaymentService();
        PaymentDelegate payment = service.ProcessPayment;   // delegate assignment

        // payment(5000);

        decimal amount = 5000;

        if(amount.isValidPayment())
        {
            payment(amount);
        } else
        {
            Console.WriteLine("Invalid amount");
        }
    }
}