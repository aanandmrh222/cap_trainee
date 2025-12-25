using System;
using System.Collections.Generic;
using Lib = Day05.Items;
using AnalyticsAlias = Day05.Analytics.LibraryAnalytics;

class Program {
    public static void Main(string[] args)
    {
        // AbstractCaller.AbstractCallerMethod();
        // InterfaceCaller.InterfaceCallerMethod();

        // +++++++++++++++++++++++++++ Library Managment +++++++++++++++++++++++++++
        // ---------------------- Task 1
        Lib.Book book = new Lib.Book
        {
        title = "C#",
        author = "adwb",
        itemId = 101,
        Status = ItemStatus.Available
        };

        book.DisplayItemsDetails();
        Console.WriteLine($"Late fee for 3 days: {book.CalculateLateFee(3)}");
        Console.WriteLine();

        Lib.Magazine magazine = new Lib.Magazine
        {
        title = "Tech Today",
        author = "qwiu",
        itemId = 201,
        Status = ItemStatus.Available
        };

        magazine.DisplayItemsDetails();
        Console.WriteLine($"Late fee for 3 days: {magazine.CalculateLateFee(3)}");


        // ------------ Task 2
        Console.WriteLine("-----------------------TASK 2 ---------------");
        // book.ReserveItem();
        // book.SendNotification("Your reserved book is ready.");


        Console.WriteLine("\n-----------------------TASK 3 POLYMORPHISM  ---------------");
        List<Lib.LibraryItem> items = new List<Lib.LibraryItem>();
        items.Add(book);
        items.Add(magazine);

        foreach(Lib.LibraryItem itm in items)
        {
            itm.DisplayItemsDetails();
            Console.WriteLine($"Late fee (3 days): {itm.CalculateLateFee(3)}\n");
            Console.WriteLine();
        }


        Console.WriteLine("\n-----------------------TASK 4 EXPLICIT INTERFACE CALL ---------------");
        Lib.IReservable revBook = book;
        Lib.INotifiable notifBook = book;

        revBook.ReserveItem();
        notifBook.SendNotification("Nofi sent");


        Console.WriteLine("\n------ USERS & ENUM DEMO ------");
        Day05.Users.Member member1 = new Day05.Users.Member { Name = "Rohit", Role = UserRole.Member };
        Day05.Users.Member librarian1 = new Day05.Users.Member { Name = "Rahul", Role = UserRole.Librarian };

        member1.DisplayRole();
        librarian1.DisplayRole();


        //  task 6
        Console.WriteLine("\n-----------------------TASK 6 ---------------");
        AnalyticsAlias.TotalBorrowedItems += 5;
        AnalyticsAlias.ShowAnalytics();
    }
}