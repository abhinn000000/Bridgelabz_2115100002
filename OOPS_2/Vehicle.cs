using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Vehicle
    {
        //Attributes
        private string ownerName;
        private string vehicleType;
        private static int registrationFee = 1000;

        //Constructor
        public Vehicle(string ownerName, string vehicleType) {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        //Updating registration fee
        public static void UpdateRegistrationFee()
        {
            Console.WriteLine("Enter the new registration fee");
            int newRegistrationFee = Convert.ToInt32(Console.ReadLine());
            registrationFee = newRegistrationFee;
        }

        //Display all details
        public void DisplayVehicleDetails() {
            Console.WriteLine("The name of the owner is "+ ownerName);
            Console.WriteLine("The vehicle type is " + vehicleType);
            Console.WriteLine("The registration fee is " + registrationFee);
        }
    }

    public class program10 {
        //public static void Main(String[] args)
        //{
        //    Vehicle vehicle1 = new Vehicle("Ashish", "Four Wheeler");
        //    vehicle1.DisplayVehicleDetails();
        //    Vehicle.UpdateRegistrationFee();
        //    vehicle1.DisplayVehicleDetails();
        //}
    }

}
