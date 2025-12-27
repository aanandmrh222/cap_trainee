using System;

class PatientBill
{
    public string BillId;
    public string PatientName;
    public bool HasInsurance;

    public double ConsultationFee;
    public double LabCharges;
    public double MedicineCharges;

    public double GrossAmount;
    public double DiscountAmount;
    public double FinalPayable;
}

class BillingService
{
    public static PatientBill LastBill = null;
    public static bool HasLastBill = false;

    // 1. Create/Register Method ----------
    public static void CreateNewBill()
    {
        PatientBill bill = new PatientBill();

        Console.Write("Enter Bill Id: ");
        bill.BillId = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(bill.BillId))
        {
            Console.WriteLine("Bill Id cannot be empty.");
            return;
        }

        Console.Write("Enter Patient Name: ");
        bill.PatientName = Console.ReadLine();


        Console.Write("Is the patient insured? (Y/N): ");
        string ins = Console.ReadLine();

        if (ins == "Y" || ins == "y") bill.HasInsurance = true;
        else bill.HasInsurance = false; 

        Console.Write("Enter Consultation Fee: ");
        bill.ConsultationFee = Convert.ToDouble(Console.ReadLine());
        if (bill.ConsultationFee <= 0)
        {
            Console.WriteLine("Consultation Fee must be greater than 0.");
            return;
        }

        Console.Write("Enter Lab Charges: ");
        bill.LabCharges = Convert.ToDouble(Console.ReadLine());
        if (bill.LabCharges < 0)
        {
            Console.WriteLine("Lab Charges cannot be negative.");
            return;
        }

        Console.Write("Enter Medicine Charges: ");
        bill.MedicineCharges = Convert.ToDouble(Console.ReadLine());

        if (bill.MedicineCharges < 0)
        {
            Console.WriteLine("Medicine Charges cannot be negative.");
            return;
        }

        // --- Billing Rules
        bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;

        if (bill.HasInsurance) {
            bill.DiscountAmount = bill.GrossAmount * 0.10;
        }
        else
        {
            bill.DiscountAmount = 0;
        }

        bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

        LastBill = bill;
        HasLastBill = true;

        Console.WriteLine("Bill created successfully ✅✅");
        Console.WriteLine("Gross Amount: " + bill.GrossAmount);
        Console.WriteLine("Discount Amount: " + bill.DiscountAmount);
        Console.WriteLine("Final Payable: " + bill.FinalPayable);
    }

    // 2. View Bill --------
    public static void ViewLastBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
            return;
        }

        Console.WriteLine("\n-----  Last Bill Details 🚀-----");
        Console.WriteLine("Bill Id: " + LastBill.BillId);
        Console.WriteLine("Patient Name: " + LastBill.PatientName);
        Console.WriteLine("Insured: " + (LastBill.HasInsurance ? "Yes" : "No"));
        Console.WriteLine("Consultation Fee: " + LastBill.ConsultationFee);
        Console.WriteLine("Lab Charges: " + LastBill.LabCharges);
        Console.WriteLine("Medicine Charges: " + LastBill.MedicineCharges);
        Console.WriteLine("Gross Amount: " + LastBill.GrossAmount);
        Console.WriteLine("Discount Amount: " + LastBill.DiscountAmount);
        Console.WriteLine("Final Payable: " + LastBill.FinalPayable);
    }

    // 3. Clear Bill --------
    public static void ClearLastBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared ❌");
    }
}

class MediSureClinicCaller
{
    public static void MediSureClinicAssiM()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n ================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BillingService.CreateNewBill();
                    break;

                case 2:
                    BillingService.ViewLastBill();
                    break;

                case 3:
                    BillingService.ClearLastBill();
                    break;

                case 4:
                    Console.WriteLine("Thank you. Application closed normally. 👍");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
