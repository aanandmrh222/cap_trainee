using System;
using System.Collections;
using System.Collections.Generic;

abstract class EmployeeRecord
{
    public string? EmployeeName {get; set;}
    public double[]? WeeklyHours {get; set;}

    public abstract double GetMonthlyPay();

}


class FullTimeEmployee : EmployeeRecord
{
    public double HourlyRate {get; set;}
    public double MonthlyBonus {get; set;}

    public override double GetMonthlyPay()
    {
        double totalHoursInweek = 0;
        foreach(double hrs in WeeklyHours) { 
            totalHoursInweek += hrs; 
        }

        double monthlyPay = (totalHoursInweek * HourlyRate) + MonthlyBonus;
    
        return monthlyPay;
    }
}


class ContractEmployee : EmployeeRecord
{
    public double HourlyRate {get; set;}
    public override double GetMonthlyPay()
    {
        double totalHoursInweek = 0;
        foreach(double hrs in WeeklyHours) { 
            totalHoursInweek += hrs; 
        }
    
        return totalHoursInweek * HourlyRate;
    }
}


class AssignmentCaller
{
    public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();

    public void RegisterEmployee(EmployeeRecord record)
    {
        PayrollBoard.Add(record);
    }

    public Dictionary<string, int> GetOvertimeWeekCounts(List<EmployeeRecord> records, double hoursThreshold)
    {
        Dictionary<string, int> res = new Dictionary<string, int>();
        foreach(EmployeeRecord rec in records)
        {
            int count = 0;
            foreach(double hr in rec.WeeklyHours)
            {
                if(hr >= hoursThreshold) count++;
            }

            if(count > 0)
            {
                res.Add(rec.EmployeeName, count);
            }
        }

        return res;
    }


    public double CalculateAverageMonthlyPay()
    {
        if(PayrollBoard.Count == 0)
        {
            return 0;
        }

        double totalPay = 0;

        foreach(EmployeeRecord rec in PayrollBoard)
        {
            totalPay += rec.GetMonthlyPay();
        }

        return totalPay/PayrollBoard.Count;
    }



    public static void AssignmentCallerMethod()
    {
        AssignmentCaller caller = new AssignmentCaller();
        bool run = true;

        while (run)
        {
            Console.WriteLine("1. Register Employee");
            Console.WriteLine("2. Show Overtime Summary");
            Console.WriteLine("3. Calculate Average Monthly Pay");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Select Employee Type (1-Full Time, 2-Contract): ");
                    int type = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.Write("Enter Employee Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Enter Hourly Rate: ");
                    double rate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    double bonus = 0;
                    if (type == 1)
                    {
                        Console.Write("Enter Monthly Bonus: ");
                        bonus = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                    }

                    Console.Write("Enter weekly hours (Week 1 to 4): ");
                    double[] hours = new double[4];
                    for (int i = 0; i < 4; i++)
                    {
                        hours[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine();

                    if (type == 1)
                    {
                        caller.RegisterEmployee(new FullTimeEmployee
                        {
                            EmployeeName = name,
                            HourlyRate = rate,
                            MonthlyBonus = bonus,
                            WeeklyHours = hours
                        });
                    }
                    else
                    {
                        caller.RegisterEmployee(new ContractEmployee
                        {
                            EmployeeName = name,
                            HourlyRate = rate,
                            WeeklyHours = hours
                        });
                    }

                    Console.WriteLine("Employee registered successfully");
                    Console.WriteLine("\n---\n");
                    break;

                case 2:
                    Console.Write("Enter hours threshold: ");
                    double threshold = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    var data = caller.GetOvertimeWeekCounts(PayrollBoard, threshold);

                    if (data.Count == 0)
                    {
                        Console.WriteLine("No overtime recorded this month");
                    }
                    else
                    {
                        foreach (var d in data)
                        {
                            Console.WriteLine(d.Key + " - " + d.Value);
                        }
                    }

                    Console.WriteLine("\n---\n");
                    break;

                case 3:
                    double avg = caller.CalculateAverageMonthlyPay();
                    Console.WriteLine("Overall average monthly pay: " + avg);
                    Console.WriteLine("\n---\n");
                    break;

                case 4:
                    Console.WriteLine("Logging off — Payroll processed successfully!");
                    run = false;
                    break;
            }
        }
    }
}