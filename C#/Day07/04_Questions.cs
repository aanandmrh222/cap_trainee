using System;
using System.Collections;
using System.Collections.Generic;

class Questions1
{
    public static void QuestionsM()
    {
        // frequency of each element in an array.
        int[] arr = {1, 2, 3, 2, 1, 4, 2};
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach(int n in arr)
        {
            if(freq.ContainsKey(n))
            {
                freq[n]++;
            }
            else
            {
                freq[n] = 1;
            }
        }

        foreach(var item in freq)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }


        string name = "aanand";
        Console.WriteLine("Char access " + name[0].ToString());
        Dictionary<string, int> fr = new Dictionary<string, int>();
        for(int m=0; m<name.Length; m++)
        {
            if(fr.ContainsKey(name[m].ToString())) {
                fr[name[m].ToString()]++;
            }
            else
            {
                fr[name[m].ToString()] = 1;
            }
        }

        foreach(var item in fr)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }



        // Merge two sorted arrays into a single sorted array.
        int[] arr1 = {1, 3, 5};
        int[] arr2 = {2, 4, 6};

        int[] merged = new int[arr1.Length + arr2.Length];
        int i = 0, j = 0, k = 0;

        while(i < arr1.Length && j < arr2.Length)
        {
            if(arr1[i] < arr2[j])
            {
                merged[k] = arr1[i];
                i++;
                k++;
            }
            else
            {
                merged[k] = arr2[j];
                j++;
                k++;
            }
        }
        
        while(i < arr1.Length)
        {
            merged[k] = arr1[i];
            i++;
            k++;
        }

        while(j < arr2.Length)
        {
            merged[k] = arr2[j];
            j++;
            k++;
        }
        
        Console.WriteLine("Merged array:");
        foreach (int num in merged)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

    }
}