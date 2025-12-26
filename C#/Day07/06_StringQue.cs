using System;
using System.Runtime.CompilerServices;

class StringQue
{
    public static string CleanseAndInvert(string input)
    {
        // convsert to lower case
        input = input.ToLower();

        // Remove all characters whose ASCII values are even numbers 
        string res = "";
        foreach(char ch in input)
        {
            if((int) ch % 2 != 0)
            {
                res += ch;
            }
        }

        // reverse the string
        string rev = "";
        for(int i=res.Length-1; i>=0; i--)
        {
            rev += res[i];
        }

        // one lower case and one upper case letter alternately
        string finalRes = "";
        for(int i=0; i<rev.Length; i++)
        {
            if(i%2!=0)
            {
                finalRes += Char.ToLower(rev[i]);
            } else
            {
                finalRes += Char.ToUpper(rev[i]);
            }
        }
        return finalRes;
    }

    public static void StringQueM()
    {
        Console.Write("Enter the input string: ");
        string input = Console.ReadLine();

        string output = CleanseAndInvert(input);

        Console.WriteLine("Original string: " + input);
        Console.WriteLine("After cleansing and inverting: " + output);
    }
}