using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class program7
{
    static void Main()
    {
        string json = @"
        [
            { ""Name"": ""Alice"", ""Age"": 30, ""Email"": ""alice@example.com"" },
            { ""Name"": ""Bob"", ""Age"": 22, ""Email"": ""bob@example.com"" },
            { ""Name"": ""Charlie"", ""Age"": 28, ""Email"": ""charlie@example.com"" }
        ]";

        List<Person> people = JsonSerializer.Deserialize<List<Person>>(json);

        var filteredPeople = people.Where(p => p.Age > 25);

        string filteredJson = JsonSerializer.Serialize(filteredPeople, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine(filteredJson);
    }
}
