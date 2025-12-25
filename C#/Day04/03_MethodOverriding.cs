/*
METHOD OVERRIDING
    - Requires virtual (parent) + override (child)
    - Runtime polymorphism
    - Decision based on OBJECT type
*/

class _23_Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class _23_Dog : _23_Animal
{
    // override -> Replaces parent method behavior
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}


/*
base KEYWORD WITH METHOD OVERRIDING

base.method():
- Calls parent version of overridden method
- Used to EXTEND behavior, not replace fully
*/

class _23_AnimalBase
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class _23_DogDerived : _23_AnimalBase
{
    public override void Speak()
    {
        base.Speak();     // Parent behavior -> (Animal speaks)
        Console.WriteLine("Dog speaks");
    }
}


/*
METHOD HIDING --> Method hiding occurs when a child class hides a parent class method using the 
                    new keyword, and method calls are resolved at compile time based on reference type.

            - Uses new keyword
            - Compile-time binding
            - Depends on REFERENCE type
            - Does NOT support polymorphism
            -----Method call depends on the REFERENCE TYPE, not the OBJECT TYPE.
*/

class _23_ParentHide
{
    public void Show()
    {
        Console.WriteLine("Parent Show");
    }
}
class _23_ChildHide : _23_ParentHide
{
    public new void Show()
    {
        Console.WriteLine("Child Show");
    }
}


/*
STATIC METHOD HIDING
        Rule:
        Static methods CANNOT be overridden
        They can ONLY be hidden using new
*/

class _23_StaticA
{
    public static void Display()
    {
        Console.WriteLine("Static A");
    }
}

class _23_StaticB : _23_StaticA
{
    public new static void Display()
    {
        Console.WriteLine("Static B");
    }
}