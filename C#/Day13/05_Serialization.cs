using System; 
using System.IO; 
using System.Text.Json;
using System.Xml.Serialization;

public class User1
{ 
    public int Id { get; set; } 
    public string Name { get; set; } 
} 

class SerializationClass 
{ 
    public static void SerializationClassM() 
    { 
        // User1 user = new User1 { Id = 2, Name = "Ayush" }; 
        // string json = JsonSerializer.Serialize(user); 
        // File.WriteAllText("05_user.json", json); 
        // Console.WriteLine("User serialized successfully."); 


        // string json = File.ReadAllText("05_user.json");
        // User1 user = JsonSerializer.Deserialize<User1>(json);
        // Console.WriteLine($"User1 Loaded {user.Id}, {user.Name}");


        User1 user = new User1{Id=1, Name="Aanand"};
        XmlSerializer serializer = new XmlSerializer(typeof(User1));
        using (FileStream fs = new FileStream("05_user.xml", FileMode.Create))
        {
            serializer.Serialize(fs, user);
        }
        Console.WriteLine("XML Serialized");

        
    } 
} 