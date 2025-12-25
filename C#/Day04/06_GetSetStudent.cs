class _25_Student
{
    private string? name;
    private int age;
    private int marks;


    //Property for name
    public string Name
    {
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }
        get
        {
            return name!;
        }
    }

    //Property for age
    public int Age
    {
        set
        {
            if (value > 0)
            {
                age = value;
            }
        }

        get
        {
            return age;
        }
    }

    //Propert for marks
    public int Marks
    {
        set
        {
            if (value >= 0 && value <= 100)
            {
                marks = value;
            }
        }
        get
        {
            return marks;
        }
    }


    public void DisplayDetails()
    {
        Console.WriteLine($"Name of the student is ::>> {name}");
        Console.WriteLine($"Age of {name} is {age}");
        Console.WriteLine($"Marks of {name} is {marks}");
    }

}

class _25_Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Area => Length * Width; //expression-bodied operator
}