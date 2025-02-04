using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Product1
    {
        //Attributes
        private static int discount = 10 ;
        private string productName;
        private double price;
        private int quantity;
        private readonly int productID;

        //Constructor
        public Product1(string productName,double price,int quantity,int productID){
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
            this.productID = productID;
        }

        //Updating Discount
        public static void updateDiscount()
        {
            Console.WriteLine("Enter the new discount ");
            int newDiscount = Convert.ToInt32(Console.ReadLine());
            discount = newDiscount;
        }

        //Displaying details
        public void DisplayDetails()
        {
            if (this is Product1)
            {
                Console.WriteLine("The current discount is " + discount);
                Console.WriteLine("The name of the product is " + productName);
                Console.WriteLine("The price of the product is " + price);
                Console.WriteLine("The quantity of the product is " + quantity);
                Console.WriteLine("The productID of the product is " + productID);
            }
        }
    }

    class program18 {
        //public static void Main(String [] args)
        //{
        //    Product1 product1 = new Product1("Shampoo", 189, 103, 789);
        //    product1.DisplayDetails();
        //    Product1.updateDiscount();
        //    Product1 product2 = new Product1("Face Wash", 129, 13, 729);
        //    product2.DisplayDetails();
        //}
    }
}
