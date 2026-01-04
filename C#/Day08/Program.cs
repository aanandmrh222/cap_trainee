using System;
class Program
{
    public static void Main()
    {
        // int a=9;
        // int b=0;
        // try {
        // int res = a/b;
        // }
        // catch(Exception e){
        //     Console.WriteLine(e.Message);
        // }


        // 01_Try-Catch --------------------
        // TryCatchCaller.TryCatchCallerM();


        // 02_ Nested try catch ---------
        // Normal.NormalMethod();


        // 03_Banking System 
        BankingSystem.BankingSystemCaller.BankingSystemCallerM();



        /*

        FileStream file = null;
        try
        {
            // file = new FileStream("data.txt", FileMode.Open);
            // // Perform file operations
            // int data = file.ReadByte();
            // Console.WriteLine(data);

            file = new FileStream("data.txt", FileMode.Open, FileAccess.Read);

            byte[] buffer = new byte[file.Length];
            file.Read(buffer, 0, 2);

            string content = System.Text.Encoding.UTF8.GetString(buffer);
            Console.WriteLine("File Content:");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found: " + ex.Message);
        }
        finally
        {
            if (file != null)
            {
                file.Close(); // Ensures file is always closed
                Console.WriteLine("File stream closed in finally block.");
            }
        }


        try
        {
            // Simulate database operation
            throw new SqlException("Connection failed");
        }
        catch (SqlException ex)
        {
            // Wrap low-level exception into higher-level exception
            throw new Exception("Database operation failed in Service Layer", ex);
        }
        */

        


    }
}
