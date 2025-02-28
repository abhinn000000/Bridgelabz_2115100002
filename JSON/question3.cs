using System;
using System.IO;
using System.Text.Json;

class program3
{
    static void Main()
    {
        string filePath = "data.json"; 

        string jsonString = File.ReadAllText(filePath);

        using JsonDocument doc = JsonDocument.Parse(jsonString);
        JsonElement root = doc.RootElement;

        string name = root.GetProperty("name").GetString();
        string email = root.GetProperty("email").GetString();

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Email: {email}");
    }
}
