using System;
using System.IO;

class FileInfoClass
{
    public static void FileInfoClassM()
    {
        FileInfo file = new FileInfo("03_FileInfo.txt");

        if(!file.Exists)
        {
            using (StreamWriter writer = file.CreateText())
            {
                writer.WriteLine("Hello FileInfo Class");
            }
        }

        Console.WriteLine("File Name: " + file.Name);
        Console.WriteLine("File Size: " + file.Length + " bytes");
        Console.WriteLine("Created On: " + file.CreationTime);
    }
}