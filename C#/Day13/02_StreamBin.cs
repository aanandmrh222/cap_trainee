// using System;
// using System.IO;


// class User
// {
//     public int Id;
//     public string Name;
// }

// class StreamBin
// {
//     static void StreamBinM()
//     {
//         // string path = @"C:\Users\Aanand\Desktop\Cap_Trainee\data1.txt";
//         string path = "data.txt";
//         // File.WriteAllText(path, "Hello append as");
//         // File.AppendAllText(path, "this is append");
//         // Console.WriteLine("done");

//         // string content = File.ReadAllText(path);
//         // Console.WriteLine(content);


//         // using (StreamWriter writer = new StreamWriter(path))
//         // {
//         //     writer.WriteLine("Application started");
//         //     writer.WriteLine("Processing Data");
//         //     writer.WriteLine("Application end");
//         // } 

//         // using (StreamReader reader = new StreamReader(path))
//         // {
//         //     string line;
//         //     while((line=reader.ReadLine()) != null)
//         //     {
//         //         Console.WriteLine(line);
//         //     }
//         // }


//         // --------------------------------------------------------------
//         // User user = new User{Id = 1, Name="Aanand"};

//         // using (StreamWriter writer = new StreamWriter("user.txt")) 
//         // { 
//         //     writer.WriteLine(user.Id); 
//         //     writer.WriteLine(user.Name); 
//         //     user.Id = 2;
//         //     user.Name = "Ayush";
//         //     writer.WriteLine(user.Id); 
//         //     writer.WriteLine(user.Name); 
//         // }
//         // Console.WriteLine("User data saved."); 


//         // User user = new User();
//         //  using (StreamReader reader = new StreamReader("user.txt")) 
//         // {

//         //     user.Id = int.Parse(reader.ReadLine()); 
//         //     user.Name = reader.ReadLine(); 
//         // } 
//         // Console.WriteLine($"User Loaded: {user.Id}, {user.Name}"); 


//         // User user = new User { Id = 2, Name = "Bob" }; 
 
//         // using (BinaryWriter writer = new BinaryWriter(File.Open("user.bin", FileMode.Create))) 
//         // { 
//         //     writer.Write(user.Id); 
//         //     writer.Write(user.Name); 
//         // } 
 
//         // Console.WriteLine("Binary user data saved."); 


//     }
// }
