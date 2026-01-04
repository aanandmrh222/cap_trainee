class ResourceHandler : IDisposable
{
    public ResourceHandler()
    {
        Console.WriteLine("Resource Called");
    }
    public void Dispose()
    {
        Console.WriteLine("Dispose()");
    }
}
class IDisposeClass
{
    public void IDisposeClassM()
    {
        using (ResourceHandler handler = new ResourceHandler())
        {
            Console.WriteLine("Using resource.");
        }
        Console.WriteLine("End of program.");
    }
}