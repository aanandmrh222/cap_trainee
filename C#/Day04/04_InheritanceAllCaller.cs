using System;
class InhericanceAllCaller
{
    public static void InhericanceAllCallerMethod()
    {
        Console.WriteLine("");

        // Console.WriteLine("----- ACCESS MODIFIER + CONSTRUCTOR CHAINING -----");
        // _23_FixedDeposit fd = new _23_FixedDeposit("Sandeep");
        // fd.DisplayDetails();


        // Console.WriteLine("\n----- SINGLE INHERITANCE -----");
        // _23_Car car = new _23_Car();
        // car.Start();
        // car.Drive();


        // Console.WriteLine("\n----- CONSTRUCTOR CHAINING (base) -----");
        // _23_Student student = new _23_Student("Amit", 101);
        // Console.WriteLine(student.Name);
        // Console.WriteLine(student.RollNo);


        // Console.WriteLine("\n----- MULTILEVEL INHERITANCE -----");
        // _23_Employee emp = new _23_Employee();
        // emp.Breathe();
        // emp.Think();
        // emp.Work();


        // Console.WriteLine("\n----- HIERARCHICAL INHERITANCE -----");
        // _23_Circle circle = new _23_Circle();
        // _23_Rectangle rectangle = new _23_Rectangle();
        // circle.Draw();
        // rectangle.Draw();


        // Console.WriteLine("\n----- MULTIPLE INHERITANCE USING INTERFACES -----");
        // _23_Machine machine = new _23_Machine();
        // machine.Print();
        // machine.Scan();


        // Console.WriteLine("\n----- METHOD OVERRIDING (RUNTIME POLYMORPHISM) -----");
        // _23_Animal animal = new _23_Dog();
        // animal.Sound();


        // Console.WriteLine("\n----- base KEYWORD WITH OVERRIDING -----");
        // _23_AnimalBase dogBase = new _23_DogDerived();
        // dogBase.Speak();


        // Console.WriteLine("\n----- METHOD HIDING -----");
        // _23_ParentHide p = new _23_ChildHide();
        // p.Show();
        // _23_ChildHide c = new _23_ChildHide();
        // c.Show();


        // Console.WriteLine("\n----- STATIC METHOD HIDING -----");
        // _23_StaticA.Display();
        // _23_StaticB.Display();


        // Console.WriteLine("\n----- SEALED CLASS -----");
        // _23_Security security = new _23_Security();
        // security.Access();


        // Console.WriteLine("\n----- SEALED METHOD -----");
        // _23_Parent parent = new _23_Child();
        // parent.Show();


        Console.WriteLine("\n----- COMPOSITION (HAS-A) -----");
        _23_CarComposition carComp = new _23_CarComposition();
        carComp.Drive();

    }
}