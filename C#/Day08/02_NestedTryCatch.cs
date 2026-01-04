using System;
using System.IO;

class Normal
{
    public static void NormalMethod() {
        try
        {
            try
            {   
                // Data Access Layer (DAL) / Technical Layer --> Attempt to read transaction file
                File.ReadAllText("transactions.txt");
            }
            catch (IOException ioEx)  // low level exception --> technical layer
            {
                //  Catch low-level technical exception (file system / IO error)
                // Wrap it into a higher-level business exception
                throw new ApplicationException(  
                    "Unable to load transaction data",  //  User-friendly message
                    ioEx   // Preserve original cause
                );
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Message: " + ex.Message);  // print custom for ui or user
            Console.WriteLine("Root Cause: " + ex.InnerException.Message);  // print for developer 
        }
    }
}


