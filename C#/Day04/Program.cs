using System;
namespace Day04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Bank b1 = new Bank(100);
            // b1.Print();

            // Deposite fd = new Deposite();
            // fd.Print();


            // Student student = new Student("ABC123") {
            //     AdmissionYear = 2022
            // };
            // student.StudentId = 101;
            // student.Name = "Aanand";
            // student.Age = 20;
            // student.Marks = 90;
            // student.Password = "secure123";

            // Console.WriteLine("Student Details:");
            // Console.WriteLine($"ID     : {student.StudentId}");
            // Console.WriteLine($"Name   : {student.Name}");
            // Console.WriteLine($"Age    : {student.Age}");
            // Console.WriteLine($"Marks  : {student.Marks}");
            // Console.WriteLine($"Result : {student.ResultStatus}");
            // Console.WriteLine($"Percentage      : {student.Percentage}");
            // Console.WriteLine($"Reg No          : {student.RegistrationNumber}");
            // Console.WriteLine($"Admission Year  : {student.AdmissionYear}");


            // Circle c1 = new Circle(14);
            // Console.WriteLine(c1.Area);



            // Library library = new Library();

            // // Add books using integer indexer
            // library[101] = "C# Basics";
            // library[102] = "Java Fundamentals";
            // library[103] = "Python Essentials";

            // // Retrieve using Book ID
            // Console.WriteLine(library[101]);
            // Console.WriteLine(library[102]);

            // // Retrieve using Book Title
            // Console.WriteLine(library["C# Basics"]);
            // Console.WriteLine(library["Data Structures"]); // not found


            // Student p1 = new Student("Aanand");
            // Console.WriteLine(p1);


            // --------------- Insurance Policy-------------------------------
            SecurityModule sec = new SecurityModule();
            sec.Authenticate();

            InsurancePolicy life = new LifePolicy(101, "Aanand", 5000);
            InsurancePolicy health = new HealthPolicy(102, "Ayush", 7000);

            PolicyDirectory directory = new PolicyDirectory();
            directory[0] = life;
            directory[1] = health;

            Console.WriteLine("Policy at 0 " + directory[0].PolicyHolderName);
            Console.WriteLine("Policy no of ayush " + directory["Ayush"].PolicyNumber);

            Console.WriteLine("Life Premium: " + life.CalculatePremium());
            Console.WriteLine("Health Premium: " + health.CalculatePremium());

            LifePolicy lp = new LifePolicy(103, "Ravi", 6000);
            InsurancePolicy bp = lp;

            lp.ShowPolicy();
            bp.ShowPolicy();
        }
    }

}
