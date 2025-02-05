using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    public class Customer
    {
        public string Name;
        public Bank Bank;
        public double Balance;

        public Customer(string name)
        {
            this.Name = name;
        }

        public void ViewBalance()
        {
            Console.WriteLine("The balance of " + Name + " is " + Balance);
        }
    }

    public class Bank
    {
        public string BankName;
        private List<Customer> customers = new List<Customer>();

        public void OpenAccount(Customer customer, double initialDeposit)
        {
            customer.Bank = this;
            customer.Balance = initialDeposit;
            customers.Add(customer);
            Console.WriteLine("Opened an account for " + customer.Name + " in the bank " + BankName + " with balance " + initialDeposit);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Customers of " + BankName + ":");
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine("Name: " + customers[i].Name + ", Balance: " + customers[i].Balance);
            }
        }
    }

    class program23
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank { BankName = "Yes Bank" };
            Customer customer1 = new Customer("Rajneesh");
            Customer customer2 = new Customer("Bablu");

            myBank.OpenAccount(customer1, 500);
            myBank.OpenAccount(customer2, 1000);

            myBank.DisplayDetails();

            customer1.ViewBalance();
            customer2.ViewBalance();
        }
    }
}
