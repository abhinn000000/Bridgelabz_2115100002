using System;
using System.Collections.Generic;
namespace ECommercePlatform
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: $" + Price);
        }
    }

    class Order
    {
        public int OrderID { get; set; }
        private List<Product> Products { get; set; }

        public Order(int orderID)
        {
            OrderID = orderID;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine("Order ID: " + OrderID);
            Console.WriteLine("Products in the Order:");
            foreach (var product in Products)
            {
                product.DisplayDetails();
            }
        }
    }

    class Customer
    {
        public string CustomerName { get; set; }
        private List<Order> Orders { get; set; }

        public Customer(string customerName)
        {
            CustomerName = customerName;
            Orders = new List<Order>();
        }

        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
        }

        public void DisplayCustomerOrders()
        {
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Orders:");
            foreach (var order in Orders)
            {
                order.DisplayOrderDetails();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Customer customer = new Customer("Abhinn");

            Product product1 = new Product("Laptop", 75000);
            Product product2 = new Product("Smartphone", 32000);

            Order order1 = new Order(1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            customer.PlaceOrder(order1);

            customer.DisplayCustomerOrders();
        }
    }
}