using System;
using System.Collections.Generic;
using System.Text.Json;

class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class program9
{
    static void Main()
    {
        var vehicles = new List<Vehicle>
        {
            new Vehicle { Make = "Toyota", Model = "Corolla", Year = 2022 },
            new Vehicle { Make = "Honda", Model = "Civic", Year = 2021 },
            new Vehicle { Make = "Ford", Model = "Mustang", Year = 2023 }
        };

        string jsonArray = JsonSerializer.Serialize(vehicles, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine(jsonArray);
    }
}
