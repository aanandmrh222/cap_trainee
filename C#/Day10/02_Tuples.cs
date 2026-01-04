class TupleClass
{
    public void TupleClassM()
    {
        Console.WriteLine("Answer of the calculate is " + (calculate(23, 34)));
        Console.WriteLine("Answer of the calculate sum is " + (calculate(23, 34).Sum));
        Console.WriteLine("Answer of the calculate Average is " + (calculate(23, 34).Average));
        Console.WriteLine("Answer of the calculate Diff is " + (calculate(23, 34).diff));

        var s = new Student { Id = 1, Name = "Amit" };
        Console.WriteLine("S.GetType() is ::>> "+s.GetType());
        var (sid, sname) = s;

        Console.WriteLine(sid);
        Console.WriteLine(sname);
    }

    static (int Sum, int Average, int diff) calculate(int a, int b)
    {
        return (a + b, (a + b) / 2, a - b);
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Deconstruct(out int id, out string name)
    {
        id = Id;
        name = Name;
    }
}