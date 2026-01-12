using System;



class User
    {
        public string Name {get; set;}
        public int Age {get; set;}
    }
class Program
{
    static void Main(string[] args)
    {
        // Debugger.DebuggerM();
        // Debugger2.Debugger2M();

        // int total = 0;
        // for(int i=1; i<=5; i++)
        // {
        //     // Console.WriteLine("The value of i is " + i);
        //     // Console.WriteLine("Before loop total value " + total);
        //     total += i;
        //     // Console.WriteLine("After the loop total value " + total);

        // }



        List<User> users = new List<User>();

        users.Add(new User{Name = "Aanand", Age = 20});
        users.Add(new User{Name = "Ayush", Age = 21});
        users.Add(new User{Name = "Raushan", Age = 21});
        users.Add(new User{Name = "Rohan", Age = 63});
        users.Add(new User{Name = "Mohit", Age = 52});

        foreach(var user in users)
        {
            Console.WriteLine($"User Name: {user.Name}, User Age: {user.Age}");
        }

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(45);
        queue.Enqueue(55);
        queue.Enqueue(65);
        queue.Enqueue(75);
        queue.Enqueue(25);

        while(queue.Count > 0)
        {
            Console.Write(queue.Dequeue() + " ");
        }
    }
}



