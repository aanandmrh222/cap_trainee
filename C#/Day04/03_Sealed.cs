/*
SEALED CLASSES AND METHODS

sealed class:
- Cannot be inherited

sealed method:
- Cannot be overridden further
*/

sealed class _23_Security
{
    public void Access()
    {
        Console.WriteLine("Secure Access");
    }
}


class _23_Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent Show");
    }
}
class _23_Child : _23_Parent
{
    // sealed override --> Override allowed here, Further overriding NOT allowed
    public sealed override void Show()
    {
        Console.WriteLine("Child Show");
    }
}


/*
COMPOSITION (HAS-A RELATIONSHIP)

Car HAS-A Engine

Why composition is preferred:
- Loose coupling
- Better flexibility
- Safer than inheritance
*/

class _23_Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}

class _23_CarComposition
{
    // Car USES Engine Car does NOT inherit Engine
    _23_Engine engine = new _23_Engine();

    public void Drive()
    {
        engine.Start();
        Console.WriteLine("Car driving");
    }
}