using System;
using System.Collections.Generic;
using Day05;
using Lib = Day05.Items;

class Program {
    public static void Main(string[] args)
    {
        // ---------------------- Task 1
        Lib.Book book = new Lib.Book
        {
        title = "C#",
        author = "adwb",
        itemId = 101
        };

        book.DisplayItemsDetails();
        Console.WriteLine($"Late fee for 3 days: {book.CalculateLateFee(3)}");
        Console.WriteLine();

        Lib.Magazine magazine = new Lib.Magazine
        {
        title = "Tech Today",
        author = "qwiu",
        itemId = 201
        };

        magazine.DisplayItemsDetails();
        Console.WriteLine($"Late fee for 3 days: {magazine.CalculateLateFee(3)}");


        // ------------ Task 2
        Console.WriteLine("-----------------------TASK 2 ---------------");
        // book.ReserveItem();
        // book.SendNotification("Your reserved book is ready.");


        Console.WriteLine("\n-----------------------TASK 3 ---------------");
        List<Lib.LibraryItem> items = new List<Lib.LibraryItem>();
        items.Add(book);
        items.Add(magazine);

        foreach(Lib.LibraryItem itm in items)
        {
            itm.DisplayItemsDetails();
            Console.WriteLine();
        }


        Console.WriteLine("\n-----------------------TASK 4 ---------------");
        Lib.IReservable revBook = book;
        Lib.INotifiable notifBook = book;

        revBook.ReserveItem();
        notifBook.SendNotification("Nofi sent");


        //  task 6
        Console.WriteLine("\n-----------------------TASK 6 ---------------");
        Day05.LibraryAnalytics.TotalBorrowedItems += 5;
        Day05.LibraryAnalytics.DisplayAnalytics();
    }
}