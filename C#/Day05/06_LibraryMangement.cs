using System;
using System.Collections.Generic;
public enum UserRole
{
    Admin,
    Librarian,
    Member
}

public enum ItemStatus { Available, Borrowed, Reserved, Lost }

namespace Day05
{
    namespace Items   
    {

        // ----------------- TAsk 1
        abstract class LibraryItem
        {
            public string? title {get; set;}
            public string? author {get; set;}
            public int itemId {get; set;}

            public ItemStatus Status { get; set; }

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
                Console.WriteLine($"Status: {Status}");
            }
            public override double CalculateLateFee(int days)
            {
                return days*1.0;
            }

            // methods are commented because Explicit interface implementation is used instead (Task 4)
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
                Status = ItemStatus.Reserved;
                Console.WriteLine($"Book {title} reserved successfully.");
            }
            void INotifiable.SendNotification(string message)
            {
                Console.WriteLine($"Notification for Book '{title}': {message}");
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
                Console.WriteLine($"Status: {Status}");
            }
            public override double CalculateLateFee(int days)
            {
                return days*0.5;
            }
        }

    }

    // Task 5: Namespaces & Nested Namespaces -> done✅,  Task 7: Enumerations -> done ✅
    // Task 6: Partial & Static Classes
    namespace Analytics
    {
        public partial class LibraryAnalytics
        {
            public static int TotalBorrowedItems { get; set; }
        }
        public partial class LibraryAnalytics
        {
            public static void ShowAnalytics()
            {
                Console.WriteLine($"Total Items Borrowed: {TotalBorrowedItems}");
            }
        }
    }

    namespace Users
    {
        class Member
        {
            public string Name { get; set; }
            public UserRole Role { get; set; }
            public void DisplayRole()
            {
                Console.WriteLine($"{Name} has role: {Role}");
            }

        }
    }

}
