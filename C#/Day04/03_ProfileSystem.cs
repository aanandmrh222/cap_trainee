using System;

namespace Day04
{
    public class Student
    {
        private string? name;
        private int age;
        private double marks;
        private string? password;

        // ---------- PART A: Auto-Implemented Property ----------
        public int StudentId { get; set; }

        // ---------- PART 5: Property with Public Get & Private Set ----------
        public string RegistrationNumber { get; private set; }

        // ---------- PART 6: Init-Only Property ----------
        public int AdmissionYear { get; init; }
        


         // ---------- PART D: Normal Properties with Validation ----------
        public string Name
        {
            get {return name;}

            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    name = value;   
                } else Console.WriteLine("Name cannot be empty");
            }
        }

        public int Age
        {
            get {return age;}
            set
            {
                if(value>0)
                {
                    age = value;
                } else Console.WriteLine("Age must be greater than 0.");
            }
        }

        public double Marks
        {
            get {return marks;} 
            set
            {
                if (value >= 0 && value <= 100)
                {
                    marks = value;
                }
                else Console.WriteLine("Marks must be between 0 and 100.");
            }
        }

        // ---------- PART B: Read-Only Property ----------
        public string ResultStatus
        {
            get
            {
                return marks >= 40 ? "Pass" : "Fail";
            }
        }


        // ---------- PART C: Write-Only Property ----------
        public string Password
        {
            set
            {
                if (value.Length >= 6)
                {
                    password = value;
                }
                else Console.WriteLine("Password must be at least 6 characters.");
            }
        }

        // ---------- PART 7: Expression-Bodied Property ----------
        public double Percentage => (marks / 100.0) * 100;

        // ---------- Internal Assignment for PART 5 ----------
        public Student(string regNo)
        {
            RegistrationNumber = regNo;
        }
    }


    class Circle
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public double Area
        {
            get { return Math.PI * radius * radius; }
        }
    }
}