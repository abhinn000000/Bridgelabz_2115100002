using System;
using System.Text.Json;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class program2
{
    static void Main()
    {
        var car = new Car
        {
            Make = "Toyota",
            Model = "Corolla",
            Year = 2022
        };

        string json = JsonSerializer.Serialize(car, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine(json);
    }
}
