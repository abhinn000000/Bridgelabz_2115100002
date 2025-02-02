using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class CarRental
    {
        //Attributes
        private string customerName;
        private string carModel;
        private int rentalDays;

        //Constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }

        //Adding total cost
        public int totalCost()
        {
            return rentalDays * 1200;
        }

        //display details
        public void DisplayDetails()
        {
            Console.WriteLine("The name of the customer is " + customerName);
            Console.WriteLine("The model of the car is " + carModel);
            Console.WriteLine("The number of days the car is being rented for is " + rentalDays);
            Console.WriteLine("The total cost for renting a car for " + rentalDays + " is "+ totalCost());
        }

    }
    public class program7 {
        //public static void Main(String[] args)
        //{
        //    CarRental car1 = new CarRental("Ashutosh", "Toyota Fortuner", 3);
        //    car1.DisplayDetails();
        //}
    }
}
