using System;

class EnterpriseAssignment
{
    public static void EnterpriseAssignmentM()
    {
        Console.Write("Enter the total number of products: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for(int i=0; i<n; i++)
        {
            Console.Write($"Enter the {i+1}th number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num>0) arr[i] = num;
            else Console.Write("Please, Enter only positive number");
        }

        Console.WriteLine(string.Join(" ", arr));

        int sum = 0;

        for(int i=0; i<n; i++)
        {
            sum += arr[i];
        }

        int avg = sum/n;

        Array.Sort(arr);

        for(int i=0; i<n; i++)
        {
            if(arr[i] < avg)
            {
                arr[i] = 0;
            }
        }

        Array.Resize(ref arr, n+5);

        for(int i=n-1; i<n+5; i++)
        {
            arr[i] = avg;
        }

        Console.WriteLine(string.Join(" ", arr));


    }
}