using System;

class HospitalManagementCaller
{
    public static void HospitalManagementCallerMethod()
    {
        Patient p = new Patient(1, "Rahul", 45);
        p.SetMedicalHistory("Hypertension");

        Doctor d = new Doctor("Meera", "Cardiology", "DOC-4589");

        Appointment.Schedule(p, d, DateTime.Now, mode: "Online");

        string condition = "Stable";
        // DiagnosisService.Evaluate(p.Age, ref condition, out string risk, 90, 85, 95);
        DiagnosisService.Evaluate(p.Age, ref condition, out string risk, 9, 8, 9);

        Console.WriteLine($"Condition: {condition}, Risk: {risk}");



        Bill bill = new Bill
        {
            ConsultationFee = 600,
            TestCharges = 1800,
            RoomCharges = 3000
        };

        Console.WriteLine("Total Bill: " + bill.TotalBill());

        double finalAmount = InsuranceService.ApplyCoverage(bill.TotalBill(), 20);

        Console.WriteLine("Final Payable Amount: " + finalAmount);

    }
}