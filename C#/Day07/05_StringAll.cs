/*
Internally, a string is a sequence of characters (char).
Strings are immutable → once created, they cannot be changed.

but we can create StringBuilder which is Mutable and Fast but not thread-safe -->> must be use *using System.Text;* 
When to use StringBuilder? -->> Inside loops, Large string concatenations
*/


using System;
using System.Text;

class StringAll
{
    public static void StringAllM()
    {
        string name = "Aanand Kumar";
        // Console.WriteLine(name);
        // Console.WriteLine(name.Length);
        // Console.WriteLine(name.ToUpper());
        // Console.WriteLine(name.ToLower());

        // Trim(), TrimStart(), TrimEnd()
        // Console.WriteLine(name.Contains("Kum"));

        // Console.WriteLine(name.StartsWith("Aan")); 
        // Console.WriteLine(name.EndsWith("ar"));

        // Console.WriteLine(name.IndexOf('n'));      // 2
        // Console.WriteLine(name.LastIndexOf('a'));  // 10

        // Console.WriteLine(name.Substring(0, 6)); 
        // Console.WriteLine(name.Substring(6)); 

        // Console.WriteLine(name.Replace("Kumar", "Aanand"));

        // string s = "apple,banana,orange";
        // string[] arr = s.Split(',');

        // foreach (var item in arr)
        // {
        //     Console.WriteLine(item);
        // }

        


        // string a = "Hello";  // (Intern Pool)
        // // string b = "Hello";
        // string b = new string("Hello");  // (Heap -> create new object)

        // Console.WriteLine(a == b);          // true
        // Console.WriteLine(a.Equals(b));     // true
        // Console.WriteLine(object.ReferenceEquals(a,b));// false (reference) because Same VALUE but Different MEMORY location


        // string a = "Apple";
        // string b = "Banana";
        // // string b = "Apple";

        // Console.WriteLine(string.Compare(a, b)); // -1
        // Console.WriteLine(a.CompareTo(b));       // -1



        // string s1 = "Aanand";
        // string s1 = "";
        // string s2 = "   ";

        // Console.WriteLine(string.IsNullOrEmpty(s1));       // true
        // Console.WriteLine(string.IsNullOrWhiteSpace(s2));  // true


        // char to string --------------------
        // char[] arr = {'A', 'a', 'n', 'a', 'n', 'd'};
        // Console.WriteLine(string.Join(" ", arr));

        // string name1 = new string(arr);
        // Console.WriteLine(name1);

        // to char ----------------------------  string to array
        // string s = "Aanand";
        // Console.WriteLine(s[2]);

        // char[] arr = s.ToCharArray();
        // for(int i=3; i<arr.Length; i++)
        // {
        //     Console.Write(arr[i] + " ");
        // }
        // Console.WriteLine();



        // string s = "HelloWorld";
        // Console.WriteLine(s.Remove(5)); // Hello


        // StringBuilder (Performance Optimization) ---------------------------  must be use -> using System.Text;
        // StringBuilder sb = new StringBuilder("");
        StringBuilder sb = new StringBuilder();
        Console.WriteLine(sb.ToString());
        sb.Append("Aanand");
        sb.Append(" ");
        sb.Append("Kumar");
        Console.WriteLine(sb.ToString());


    }
}