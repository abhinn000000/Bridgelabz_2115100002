using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class program10
{
    static void Main()
    {
        string json = @"
        [
            { ""Name"": ""Alice"", ""Age"": 30, ""Email"": ""alice@example.com"" },
            { ""Name"": ""Bob"", ""Age"": 22, ""Email"": ""bob@example.com"" },
            { ""Name"": ""Charlie"", ""Age"": 28, ""Email"": ""charlie@example.com"" }
        ]";

        List<User> users = JsonSerializer.Deserialize<List<User>>(json);

        var filteredUsers = users.Where(u => u.Age > 25);

        string filteredJson = JsonSerializer.Serialize(filteredUsers, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine(filteredJson);
    }
}
