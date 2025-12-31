using System;
using System.Collections;
using System.Collections.Generic;

class EnterpriseAssignment
{
    public static void EnterpriseAssignmentM()
    {
        // task 1
        Console.Write("Enter number of products: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] prices = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter price of product {i + 1}: ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value > 0)
                prices[i] = value;
            else
            {
                Console.WriteLine("Only positive prices allowed. Try again.");
                i--;
            }
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += prices[i];
        }

        int avg = sum / n;
        // int avg = 4;

        Array.Sort(prices);

        for (int i = 0; i < n; i++)
        {
            if (prices[i] < avg)
            {
                prices[i] = 0;
            }
        }

        Array.Resize(ref prices, n + 5);

        for (int i = n; i < prices.Length; i++)
        {
            prices[i] = avg;
        }

        Console.WriteLine("\nFinal Product Price Array:");
        for (int i = 0; i < prices.Length; i++)
        {
            Console.WriteLine($"Index {i}: {prices[i]}");
        }

        

        // task 2
        // Console.Write("\nEnter number of branches: ");
        // int branches = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter number of months: ");
        // int months = Convert.ToInt32(Console.ReadLine());

        // int[,] sales = new int[branches, months];

        // for (int i = 0; i < branches; i++)
        // {
        //     Console.WriteLine($"Branch {i + 1}:");
        //     for (int j = 0; j < months; j++)
        //     {
        //         Console.Write($" Month {j + 1}: ");
        //         sales[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // int highestMonthSale = 0;

        // Console.WriteLine("\n ------------- Branch Sales Totals -----------------");
        // for (int i = 0; i < branches; i++)
        // {
        //     int total = 0;
        //     for (int j = 0; j < months; j++)
        //     {
        //         total += sales[i, j];
        //         if (sales[i, j] > highestMonthSale)
        //         {
        //             highestMonthSale = sales[i, j];
        //         }
        //     }
        //     Console.WriteLine($"Branch {i + 1} Total: {total}");
        // }
        // Console.WriteLine("Highest Monthly Sale: " + highestMonthSale);

        
        
        // task 3
        // int[][] performance = new int[branches][];

        // for (int i = 0; i < branches; i++)
        // {
        //     int count = 0;
        //     for (int j = 0; j < months; j++)
        //     {
        //         if (sales[i, j] >= avg) count++;
        //     }

        //     performance[i] = new int[count];

        //     int index = 0;
        //     for (int j = 0; j < months; j++)
        //     {
        //         if (sales[i, j] >= avg)
        //         {
        //             performance[i][index] = sales[i, j];
        //             index++;
        //         }
        //     }
        // }

        // Console.WriteLine("\n ----------- Performance-Based Sales --------------------");
        // for (int i = 0; i < performance.Length; i++)
        // {
        //     Console.Write($"Branch {i + 1}: ");
        //     if (performance[i].Length == 0)
        //     {
        //         Console.WriteLine("No qualifying sales");
        //     }
        //     else
        //     {
        //         for (int j = 0; j < performance[i].Length; j++)
        //         {
        //             Console.Write(performance[i][j] + " ");
        //         }
        //         Console.WriteLine();
        //     }
        // }

        

        // task 4
        // Console.Write("Enter number of customer transactions: ");
        // int tran = Convert.ToInt32(Console.ReadLine());

        // List<int> customers = new List<int>();

        // for (int i = 0; i < tran; i++)
        // {
        //     Console.Write($"Enter customer {i+1}th ID: ");
        //     customers.Add(Convert.ToInt32(Console.ReadLine()));
        // }

        // HashSet<int> cleanSet = new HashSet<int>(customers);
        // List<int> cleanList = new List<int>(cleanSet);

        // Console.WriteLine("Cleaned Customer List:");
        // foreach (var id in cleanList)
        // {
        //     Console.Write(id + " ");
        // }
        // Console.WriteLine("\n Duplicates Removed: " + (customers.Count - cleanList.Count));


        
        // task 5
        // Console.Write("Enter number of financial transactions: ");
        // int ft = Convert.ToInt32(Console.ReadLine());

        // Dictionary<int, double> transactions = new Dictionary<int, double>();

        // for (int i = 0; i < ft; i++)
        // {
        //     Console.Write($"Enter {i+1}th transaction ID: ");
        //     int id = Convert.ToInt32(Console.ReadLine());

        //     if (!transactions.ContainsKey(id))
        //     {
        //         Console.Write("Enter amount: ");
        //         transactions.Add(id, Convert.ToDouble(Console.ReadLine()));
        //     }
        //     else
        //     {
        //         Console.WriteLine("Duplicate ID not allowed.");
        //         i--;
        //     }
        // }

        // SortedList<int, double> highValue = new SortedList<int, double>();
        // foreach (KeyValuePair<int, double> pair in transactions)
        // {
        //     if (pair.Value >= avg)
        //     {
        //         highValue.Add(pair.Key, pair.Value);
        //     }
        // }

        // Console.WriteLine("\nHigh Value Transactions:");
        // foreach (KeyValuePair<int, double> pair in highValue)
        // {
        //     Console.WriteLine($"ID: {pair.Key}, Amount: {pair.Value}");
        // }



        // task 6
        // Console.Write("\nEnter number of operations: ");
        // int z = Convert.ToInt32(Console.ReadLine());

        // Queue<string> qu = new Queue<string>();
        // Stack<string> st = new Stack<string>();

        // for (int i = 0; i < z; i++)
        // {
        //     Console.Write($"Enter {i+1}th operation: ");
        //     string op = Console.ReadLine();
        //     qu.Enqueue(op);
        //     st.Push(op);
        // }

        // Console.WriteLine("\nProcessed Operations:");
        // while (qu.Count > 0)
        //     Console.WriteLine(qu.Dequeue());

        // Console.WriteLine("\nUndo last two operations:");
        // for (int i = 0; i < 2 && st.Count > 0; i++)
        // {
        //     Console.WriteLine(st.Pop());
        // }



        // task 7
        // Console.Write("\nEnter number of users: ");
        // int users = Convert.ToInt32(Console.ReadLine());

        // Hashtable table = new Hashtable();
        // ArrayList list = new ArrayList();

        // for (int i = 0; i < users; i++)
        // {
        //     Console.Write("Enter username: ");
        //     string name = Console.ReadLine();

        //     Console.Write("Enter role: ");
        //     string role = Console.ReadLine();

        //     table.Add(name, role);
            
        //     list.Add(name);
        //     list.Add(role);
        // }

        // Console.WriteLine("\nHashtable Data:");
        // foreach (DictionaryEntry entry in table)
        // {
        //     Console.WriteLine(entry.Key + " : " + entry.Value);
        // }

        // Console.WriteLine("\nArrayList Data (Mixed Types):");
        // foreach (var p in list)
        // {
        //     Console.WriteLine(p);
        // }

        // Console.WriteLine("\nArrayList is risky because it allows mixed data types.");

    }
}
