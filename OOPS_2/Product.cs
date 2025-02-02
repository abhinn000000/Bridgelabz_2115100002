using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Product
    {
        //Attributes
        private string productName;
        private int price;
        private static int totalProducts =0 ;

        //Constructor
        public Product(string productName, int price) {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }

        //Displaying total products
        public int DisplayTotalProducts() {
            return totalProducts;
        }

        //Displaying product details
        public void DisplayProductDetails()
        {
            Console.WriteLine("The name of the product is " + productName);
            Console.WriteLine("The price of the product is " + price);
            Console.WriteLine("The total number of products is " + DisplayTotalProducts());
        }

        class program8 {
            //public static void Main(String[] args)
            //{
            //    Product product1 = new Product("Shampoo", 89);
            //    product1.DisplayProductDetails();
            //    Product product2 = new Product("Shower Gel", 119);
            //    product2.DisplayProductDetails();
            //}
        }
    }
}
