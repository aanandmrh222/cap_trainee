using System;

delegate void OrderDelegate(string id);

class NotificationService
{
    public void SendEmail(string id)
    {
        Console.WriteLine($"Email sent for order {id}");
    }
    public void SendSMS(string id)
    {
        Console.WriteLine($"SMS sent for order {id}");
    }
}


class MultiDelegateCaller
{
    public static void MultiDelegateCallerMethod()
    {
        NotificationService service = new NotificationService();

        OrderDelegate notifiy = null;    // instance of Order-Delegate
        notifiy += service.SendEmail; 
        notifiy += service.SendSMS;

        notifiy("ORD1001");



    }
}