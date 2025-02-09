using System;

// Interface
interface Refuelable
{
    void Refuel();
}

class Vehicle1
{
    //Attributes
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    //Constructor
    public Vehicle1(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }

    //show details method
    public void ShowDetails()
    {
        Console.WriteLine("Model: " + Model + ", Max Speed: " + MaxSpeed + " km/h");
    }
}

// Electric vehicle subclass
class ElectricVehicle : Vehicle1
{
    //Constructor
    public ElectricVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

    //implementation of Charge
    public void Charge()
    {
        Console.WriteLine(Model + " is charging.");
    }
}

class PetrolVehicle : Vehicle1, Refuelable
{
    //Constructor
    public PetrolVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

    //implementation of Refuel
    public void Refuel()
    {
        Console.WriteLine(Model + " is refueling with petrol.");
    }
}

class program9
{
    static void Main(string[] args)
    {
        ElectricVehicle tesla = new ElectricVehicle(200, "Tata Nexon EV");
        PetrolVehicle bmw = new PetrolVehicle(250, "BMW M3");

        tesla.ShowDetails();
        tesla.Charge();

        bmw.ShowDetails();
        bmw.Refuel();
    }
}
