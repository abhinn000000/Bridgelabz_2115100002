using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Vehicle1
    {
        //Attributes
        private static int RegistrationFee = 1000;
        private string OwnerName;
        private string VehicleType;
        private readonly int RegistrationNumber;

        //Constructor
        public Vehicle1(string OwnerName,string VehicleType,int RegistrationNumber) {
            this.OwnerName = OwnerName;
            this.VehicleType = VehicleType;
            this.RegistrationNumber = RegistrationNumber;
        }

        //updating the registration fee
        public static void updateRegisterationFee()
        {
            Console.WriteLine("Enter the new registration fee");
            int newRegistrationFee = Convert.ToInt32(Console.ReadLine());
            RegistrationFee = newRegistrationFee;
        }

        //displaying the registration fee
        public static void diplayRegistrationFee() {
            Console.WriteLine("The Registration fee is " + RegistrationFee);
        }

        //displaying details
        public void DisplayDetails()
        {
            Console.WriteLine("The Owner's name is " + OwnerName);
            Console.WriteLine("The Vehicle type is " + VehicleType);
            Console.WriteLine("The Registration number is " + RegistrationNumber);
        }

        class program20
        {
            //public static void Main(String[] args)
            //{
            //    Vehicle1.diplayRegistrationFee();

            //    Vehicle1 vehicle1 = new Vehicle1("Anuj", "Two Wheeler", 5678);
            //    vehicle1.DisplayDetails();

            //    Vehicle1.updateRegisterationFee();
            //    Vehicle1.diplayRegistrationFee();

            //}
        }


    }
}
