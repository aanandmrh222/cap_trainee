// Use Case -> Used for one-time or short-lived operations.

using System;

delegate void ErrorDelegate(string mess);

class AnonDelegate
{
    public static void AnonDelegateMethod()
    {
        ErrorDelegate errorHandler = delegate(string mess)
        {
            Console.WriteLine("Error: " + mess);
        };

        errorHandler("File not found");

    }
}