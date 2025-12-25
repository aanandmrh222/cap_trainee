using System;

// Task 2. --> Patient (Encapsulation + Constructors)
class Patient
{
    public int PatientId { get; }
    public string? Name { get; set; }
    public int Age {get; set;}
    private string medicalHistory;

    public Patient(int id, string name, int age)
    {
        PatientId = id;
        Name = name;
        Age = age;
    }

    public void SetMedicalHistory(string? history)
    {
        medicalHistory = history;
    }

    public string GetMedicalHistory()
    {
        return medicalHistory;
    }
}


// Task 3. --> Doctor (Static + Readonly)
class Doctor
{
    public static int TotalDoctors;
    public readonly string? LicenseNumber;

    public string? Name{get; set;}
    public string Specialization {get; set; }

    static Doctor()
    {
        TotalDoctors = 0;
    }

    public Doctor(string name, string specialization, string license)
    {
        Name = name;
        Specialization = specialization;
        LicenseNumber = license;
        TotalDoctors++;
    }
}


// TASK 4: APPOINTMENT CLASS (Overloading + Default Arguments)
class Appointment
{
    public static void Schedule(Patient p, Doctor d)
    {
        Console.WriteLine($"Appointment scheduled for {p.Name} with Dr. {d.Name}");
    }
    public static void Schedule(Patient p, Doctor d, DateTime date, string mode = "offline")
    {
        Console.WriteLine($"Appointment of patient {p.Name} with Dr. {d.Name} on Date {date.ToShortDateString()}, mode: {mode}");
    }
}


// TASK 5: DIAGNOSIS SERVICE – ADVANCED PARAMETER TASK (ref, out, in, params, static local function)
class DiagnosisService
{
    public static void Evaluate(in int age, ref string condition, out string riskLevel, params int[] testScore)
    {
        int totaltestScore = 0;
        foreach(int score in testScore)
        {
            totaltestScore += score;
        }

        // static bool IsCritical(int sum)
        // {
        //     if(sum > 250) return true;
        //     else return false;
        // }
        static bool IsCritical(int sum) => sum > 250;

        if (IsCritical(totaltestScore) || age>60)
        {
            condition = "Serious";
            riskLevel = "High risk";
        } else
        {
            riskLevel = "Moderate risk";
        }
    }
}


// TASK 6: BILLING CLASS – OBJECT INITIALIZER TASK (Overloading + Object Initializers)
class Bill
{
    public double ConsultationFee{get; set;}
    public double TestCharges{get; set;}
    public double RoomCharges{get; set;}

    public double TotalBill() => ConsultationFee+TestCharges+RoomCharges;
}



// TASK 7: INSURANCE SERVICE – FINANCIAL LOGIC TASK (Implicit/Explicit Casting)
class InsuranceService
{
    public static double ApplyCoverage(double totalBillAmount, int coveragePercent)
    {
        double discount = totalBillAmount * coveragePercent/100;
        return totalBillAmount - discount;
    }
}


// TASK 8: RECURSION TASK – HOSPITAL STAY
class HospitalStay
{
    static int CalculateStayDays(int days)
    {
        if (days <= 0)
            return 0;

        return 1 + CalculateStayDays(days - 1);
    }
}


// TASK 9: INPUT VALIDATION TASK (Parse, TryParse, Convert)
class InputHelper
{
    public static int ReadAge(string input)
    {
        if (int.TryParse(input, out int age))
            return age;

        throw new Exception("Invalid age input");
    }
}


// TASK 10: SYSTEM INITIALIZATION TASK (Static Constructor)
class HospitalSystem
{
    public const string HospitalName = "SmartCare Hospital";

    static HospitalSystem()
    {
        Console.WriteLine("Hospital System Booting...");
    }
}

