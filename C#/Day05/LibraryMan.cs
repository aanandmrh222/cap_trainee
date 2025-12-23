using System;
namespace Day05
{
namespace Items   
{

    public enum UserRole
    {
        Admin,
        Librarian,
        Member
    }
    public enum ItemStatus
    {
        Available,
        Borrowed,
        Reserved,
        Lost
    }

    // ----------------- TAsk 1
    abstract class LibraryItem
    {
        public string? title {get; set;}
        public string? author {get; set;}
        public int itemId {get; set;}

        public abstract void DisplayItemsDetails();
        public abstract double CalculateLateFee(int days);

    }

    // task 2 interface
    public interface IReservable
    {
        void ReserveItem();
    }
    public interface INotifiable
    {
        void SendNotification(string message);
    }

    // child class book
    class Book : LibraryItem, IReservable, INotifiable
    {
        public override void DisplayItemsDetails()
        {
            Console.WriteLine(" ++++++++ Display Book Details +++++++");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Item ID: {itemId}");
        }
        public override double CalculateLateFee(int days)
        {
            return days*1.0;
        }

        // public void ReserveItem()
        // {
        //     Console.WriteLine("Reservation success");
        // }
        // public void SendNotification(string message)
        // {
        //     Console.WriteLine($"Notification sent: {message}");
        // }

        // ---------- TASK 4: Explicit Interface Implementation
        void IReservable.ReserveItem()
        {
            Console.WriteLine("Book reserved successfully.");
        }
        void INotifiable.SendNotification(string message)
        {
            Console.WriteLine($"Notification: {message}");
        }
    }

    // child magzine
    class Magazine : LibraryItem
    {
        public override void DisplayItemsDetails()
        {
            Console.WriteLine(" +++++++++ Display MAgazine Details +++++++++++++ ");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Item ID: {itemId}");
        }
        public override double CalculateLateFee(int days)
        {
            return days*0.5;
        }
    }

}

}
