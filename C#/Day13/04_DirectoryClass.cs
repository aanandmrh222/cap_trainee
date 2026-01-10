using System;
using System.IO;

class DirectoryClass
{
    public static void DirectoryClassM()
    {
        // Directory.CreateDirectory("04_Logs");

        // if(Directory.Exists("04_Logs"))
        // {
        //     Console.WriteLine("Log directory created successfully.");
        // }


        DirectoryInfo dir = new DirectoryInfo("04_Logs1");

        if(!dir.Exists)
        {
            dir.Create();
        }

        Console.WriteLine("Directory Name: " + dir.Name);
        Console.WriteLine("Created On: " + dir.CreationTime);
        Console.WriteLine("Full Path: " + dir.FullName);

    }
}