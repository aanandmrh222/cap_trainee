class GarbageColl
{
    public void GarbageCollM()
    {
        Console.WriteLine("Creating Objects......");
        List<Object> list = new List<Object>();
        for(int i = 0; i < 5; i++)
        {
            list.Add(new MyClass());
            list.Add(new NewMyClass());

        }
        list.Clear();
        Console.WriteLine("Forcing Garbage Collector-------\n");
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("\nGarbage Collection Completed");
    }
}

class MyClass
{
    ~MyClass()
    {
        Console.WriteLine("Finalizer called, Object Collected");
    }
}
class NewMyClass
{
    ~NewMyClass()
    {
        Console.WriteLine("New Finalizer called, Object Collected");
    }
}