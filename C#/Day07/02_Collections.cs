/*
ArrayList --> is a non-generic, non-type-safe collection that causes boxing/unboxing, 
              can store different data types and is not type-safe
List<T> --> is a generic, type-safe, faster collection and is preferred in modern C#, 
            stores only the same specified type, is type-safe, and is preferred in modern C#.
Hashtable --> is a non-generic collection that stores key-value pairs
               and is non-type-safe
Dictionary<TKey, TValue> --> is a generic, type-safe collection that stores key-value pairs and is preferred in modern C#

*/


using System;
using System.Collections; // non-generic -> not type safe we can store different data types
using System.Collections.Generic; // generic -> type safe we can store only same data type

class Collections1 {
    public static void CollectionsM()
    {
        // List - >  System.Collection.Generics;
        List<int> number1 = new List<int>();
        number1.Add(10);
        number1.Add(20);
        number1.Add(30);
        Console.WriteLine(number1[1]);

        foreach(int num in number1) {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // ArrayList - > System.Collection;
        ArrayList arrayList = new ArrayList();
        arrayList.Add(100); 
        arrayList.Add("Hello");
        arrayList.Add(45.67);
        Console.WriteLine(arrayList[1]);

        foreach(var item in arrayList) {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        // HashTable - > System.Collection; and its unordered collection
        Hashtable hashtable = new Hashtable();  
        hashtable.Add("A", "Apple");  
        hashtable.Add("B", "Banana");
        hashtable.Add("C", "Cherry");
        Console.WriteLine(hashtable["B"]);
        foreach(DictionaryEntry item in hashtable) {
            Console.Write(item.Key + ":" + item.Value + " ");
        }
        Console.WriteLine();


        // Dictionary -> System.Collection.Generics;
        Dictionary<int, string> dictionary = new Dictionary<int, string>();  
        dictionary.Add(1, "One");   
        dictionary.Add(2, "Two");
        dictionary.Add(3, "Three");
        Console.WriteLine(dictionary[2]);
        foreach(var item in dictionary) {
            Console.Write(item.Key + ":" + item.Value + " ");
        }
        Console.WriteLine();

        
        // Stack -> non-generic, LIFO
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine(stack.Pop()); // 3
        foreach(var item in stack) {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        // Queue -> non-generic, FIFO
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine(queue.Dequeue()); // 1
        foreach(var item in queue) {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        // HashSet -> generic, no duplicate, its unordered
        HashSet<int> hashSet = new HashSet<int>();
        hashSet.Add(10);
        hashSet.Add(20);
        hashSet.Add(20);
        hashSet.Add(30);
        // foreach(var item in hashSet)
        // {
        //     Console.Write(item + " ");
        // }
        Console.WriteLine(string.Join(" ", hashSet));


        // SortedList -> generic, sorted by key, ordered — elements are automatically sorted by key.
        SortedList<string, string> sortedList = new SortedList<string, string>();
        sortedList.Add("b", "B");
        sortedList.Add("a", "A");
        sortedList.Add("c", "C");
        Console.WriteLine(sortedList["b"]);
        Console.WriteLine(string.Join(" ", sortedList));
        Console.WriteLine(string.Join(" ", sortedList.Reverse()));  // Only for Printing, NOT real sorting(Does NOT change internal order)


        // using TryGetValue -> to safely retrieve value by key
        if(sortedList.TryGetValue("d", out string value))   // value of key is stored in 'value' variable
        {
            Console.WriteLine("Key found: " + value);
        }
        else
        {
            Console.WriteLine("Key not found");
        }

        foreach(var item in sortedList)
        {
            Console.Write(item.Key + ":" + item.Value + " ");
        }
        Console.WriteLine();

    }
}