using System;
using System.Collections.Generic;

public delegate bool IsEligibleforScholarship(Student std);


public class Student
{
    public int ROllNo {get; set;}
    public string Name {get; set;}
    public int Marks {get; set;}
    public char SportsGrade {get; set;}

    public static string GetEligibleStudent(List<Student> studentList, IsEligibleforScholarship isEligible)
    {
        List<string> eligibleName = new List<string>();

        foreach(Student st in studentList)
        {
            if(isEligible(st))
            {
                eligibleName.Add(st.Name);
            }
        }

        return string.Join(" ", eligibleName);
    }
}

class Caller
{
    static bool ScholarshipEligible(Student st)
    {
        return st.Marks>80 && st.SportsGrade=='A';
    }

    public static void CallerMethod()
    {
        List<Student> lstStudents = new List<Student>();
        Student obj1 = new Student() {ROllNo = 1, Name="Raj", Marks=75, SportsGrade='A'};
        Student obj2 = new Student() {ROllNo = 2, Name="Rahul", Marks=82, SportsGrade='A'};
        Student obj3 = new Student() {ROllNo = 3, Name="Kiran", Marks=89, SportsGrade='B'};
        Student obj4 = new Student() {ROllNo = 4, Name="Sunil", Marks=86, SportsGrade='A'};

        lstStudents.Add(obj1);
        lstStudents.Add(obj2);
        lstStudents.Add(obj3);
        lstStudents.Add(obj4);

        IsEligibleforScholarship eligibleSt = ScholarshipEligible;

        string res = Student.GetEligibleStudent(lstStudents, eligibleSt);

        Console.WriteLine(res);

    }
}