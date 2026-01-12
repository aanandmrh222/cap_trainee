using System;

// TASK 1: Custom Delegate – Single-Cast Discharge Report
public delegate string ReportGenerator(string patientName);

// TASK 2: Multicast Delegate – Emergency Alert Broadcasting
public delegate void HospitalAlert(string message);

// TASK 3: Event-Based Delegate – Patient Admission Notification
public delegate void HospitalNotificationHandler(string message, DateTime time);

public class HospitalNotifier
{
    public event HospitalNotificationHandler PatientAdmitted;

    public void AdmitPatient(string name)
    {
        if (PatientAdmitted != null)
        {
            PatientAdmitted($"Patient {name} admitted successfully.", DateTime.Now);
        }
    }
}


public class AdministrationDepartment
{
    public void Notify(string message, DateTime time)
    {
        Console.WriteLine($"[ADMIN] {message} | {time}");
    }
}