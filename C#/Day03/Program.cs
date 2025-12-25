using System;

namespace Day03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. -------------------------- Class and Object
            // BankAccount bankAccount = new BankAccount();
            // bankAccount.accNum = 123;
            // bankAccount.balance = 500000;
            // Console.WriteLine($"Acc no: {bankAccount.accNum} and balance {bankAccount.balance}");
            // bankAccount.Deposit(10000);
            // Console.WriteLine($"Acc no: {bankAccount.accNum} and balance {bankAccount.balance}");

            // 2. ----------------- Fields and Methods
            // Employee emp = new Employee();
            // emp.name = "Aanand";
            // emp.salary = 1000000;
            // emp.DisplayDetails();


            // 3. -------------------------- Access Modifiers
            // Wallet wl = new Wallet(100);
            // double balance1 = wl.GetBalance();
            // Console.WriteLine($"Wallet Balance is {balance1}");
            // wl.AddMoney(200);
            // double balance2 = wl.GetBalance();
            // Console.WriteLine($"Wallet Balance is {balance2}");

            
            // 7. ------------------------ Method Parameters & Overloading
            // MathOps math = new MathOps();
            // Console.WriteLine(math.Add(1,2));
            // Console.WriteLine(math.Add(1,2,3));
            // Console.WriteLine(math.Add(3.5,2.4));
            // Console.WriteLine(math.Add(3.5));


            // ---------------------Default + Named Arguments (Combined)
            // Person p1 = new Person();
            // p1.PersonDet("Aanand", 20, "Phagwara", 'M');
            // p1.PersonDet("Ayush", 20);
            // p1.PersonDet("Raushan", 20, "Hardaspur");


            // ---------------- for Each Example  ------------------------
            // Practice.forEachEample("Aanand");
            // Practice.sum(1,2,3,4);
            // Practice.sum(1,2,3,4,5);
            // Practice.sum(1,2,3,4,5,6,7);


            // ------------------ Reference Example   -----------------------------
            // int x = 20;
            // Console.WriteLine("Before : " + x);
            // Practice.decreaseByTen(ref x);
            // Console.WriteLine("After : " + x);

            // ------------------ Out keyword Example -----------------------
            // int q = 0, r = 0;
            // Practice.Divide(10, 3, out q, out r);
            // Console.WriteLine("Quotient = " + q);
            // Console.WriteLine("Remainder = " + r);

            // string result;
            // Practice.GetResult(75, out result);
            // Console.WriteLine(result);

            // int x = 50;
            // Practice.Show(in x);

            // Practice.DefaultThenParams(12, 1,2,3,4);

            // this method give error because "param" needs to be at last
            // Practice.ParamsThenDefault(12, 1,2,3,4,5);

            // int[] arr = {1,2,3,4};
            // Practice.ParamsArray(arr);
            // Practice.ParamsArray({1,2,3,4});

            // Local Method Example
            // Practice.Process();


            // Reference Example   -----------------------------
            // Reference refObj = new Reference();
            // refObj.runProgram();


            // ------------ Function inside function
            // Calculator.CalCu();


            // ------------ Lambda function
            // LambdaFunction.Example();


            // ----------------- Recursion
            // RecursionCaller.RecursionCallerMethod();


            // Assignement

            // BankCaller.BankCallerMethod();

            HospitalManagementCaller.HospitalManagementCallerMethod();

            
    }
    }
}