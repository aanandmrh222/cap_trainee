using System;
using System.Diagnostics;

class Button
{
    // step 1: Declare a delegate
    public delegate void ClickHandler();

    // step 2: Declare an event using delegate
    public event ClickHandler Clicked;   // event are build on top of the delegate

    // step 3
    public void Click()
    {
        Clicked?.Invoke();
    } 
}


class ButtonCaller
{
    public static void ButtonCallerMethod()
    {
        Button btn = new Button();

        // step 4: Subscribe a method to the event
        btn.Clicked += () => Console.WriteLine("Button was Clicked");

        // step 5: Trigger the event
        btn.Click();
    }
}