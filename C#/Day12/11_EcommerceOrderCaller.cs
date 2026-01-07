using System;
using System.Collections.Generic;
using EcommerceAssessment;

class EcommerceOrderCaller
{
    public static void EcommerceOrderCallerM()
    {
        Repository<Order> orderRepo = new Repository<Order>();
        orderRepo.Add(new Order {OrderId=1, CustomerName="Aanand", Amount=5000});
        orderRepo.Add(new Order {OrderId=1, CustomerName="Ayush", Amount=2000});
        orderRepo.Add(new Order {OrderId=1, CustomerName="Raushan", Amount=3000});

        // delegate
        Func<double, double> taxCalculator = amount => amount*0.18;
        Func<double, double> discountCalculator = amount => amount*0.05;
        Predicate<Order> validator = order => order.Amount >= 3000;

        // callback
        OrderCallback callback = message => Console.WriteLine($"Callback : {message}");

        // event 
        Action<string> logger = message => Console.WriteLine($"Logger : {message}");
        Action<string> notifier = message => Console.WriteLine($"Notifier : {message}");

        // processor
        OrderProcessor processor = new OrderProcessor();

        processor.OrderProcessed += logger;
        processor.OrderProcessed += notifier;

        // process order
        foreach(var order in orderRepo.GetAll())
        {
            processor.ProcessOrder(
                order,
                taxCalculator,
                discountCalculator,
                validator,
                callback
            );
            Console.WriteLine();
        }

        List<Order> orders = orderRepo.GetAll();
        orders.Sort((o1,o2) => o2.Amount.CompareTo(o1.Amount));

        Console.WriteLine("Sorted Orders in Descending Amount");
        foreach(var order in orders)
        {
            Console.WriteLine(order);
        }
    }
}