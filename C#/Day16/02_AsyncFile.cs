using System;
using System.IO;
using System.Threading.Tasks;

class AsyncFile
{
    public static async Task AsyncFileM()
    {
        Console.WriteLine("Start reading file...");

        string content = await File.ReadAllTextAsync("02_data.txt");

        Console.WriteLine("File content:");
        Console.WriteLine(content);

        Console.WriteLine("End of program");

        

    }
}
