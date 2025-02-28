using System;
using System.Text.Json;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Subjects { get; set; }
}

class program1
{
    static void Main()
    {
        var student = new Student
        {
            Name = "Don",
            Age = 20,
            Subjects = new List<string> { "Math", "Science", "History" }
        };

        string json = JsonSerializer.Serialize(student, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(json);
    }
}
