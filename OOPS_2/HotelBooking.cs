using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class HotelBooking
    {
        //Attributes
        private string guestName;
        private string roomType;
        private int nights;

        //Constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        //Copy Constructor
        public HotelBooking(HotelBooking booking)
        {
            guestName = booking.guestName;
            roomType = booking.roomType;
            nights = booking.nights;
        }

        //Default Constructor using chaining
        public HotelBooking() : this("No name found", "No room type found", 0)
        {

        }

        //Displaying details
        public void displayDetails()
        {
            Console.WriteLine("The name of the guest is " + guestName);
            Console.WriteLine("The type of the room is " + roomType);
            Console.WriteLine("The number of nights the guest is staying is " + nights);
        }
    }

    public class program6 {
        //public static void Main(String[] args)
        //{
        //    HotelBooking booking1 = new HotelBooking("Ayush", "Suite", 1);
        //    booking1.displayDetails();
        //    HotelBooking booking2 = new HotelBooking(booking1); //calling copy constructor
        //    booking2.displayDetails();
        //    HotelBooking booking3 = new HotelBooking(); //calling default constructor
        //    booking3.displayDetails();

        //}
    }
}
