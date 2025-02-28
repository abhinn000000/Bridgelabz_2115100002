using System;
using System.Collections.Generic;
using System.Text.Json;

class Car1
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class program6
{
    static void Main()
    {
        var cars = new List<Car1>
        {
            new Car1 { Make = "Toyota", Model = "Corolla", Year = 2022 },
            new Car1 { Make = "Honda", Model = "Civic", Year = 2021 },
            new Car1 { Make = "Ford", Model = "Mustang", Year = 2023 }
        };

        string jsonArray = JsonSerializer.Serialize(cars, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine(jsonArray);
    }
}
