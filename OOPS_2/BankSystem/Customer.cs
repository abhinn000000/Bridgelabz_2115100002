using System;
namespace BankAccount_Functions
{
    //class Customer to save account holder information
    internal class Customer
    {
        public string customerName;
        private double currentBalance;
        private readonly int accountNumber;

        //Constructor
        public Customer(string customerName, int accountNumber, double currentBalance)
        {
            this.customerName = customerName;
            this.currentBalance = currentBalance;
            this.accountNumber = accountNumber;
        }

        //get method for Customer name
        public string CustomerName
        {
            get { return customerName; }
        }

        //get and set methods for balance
        public double CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        }

        //get method for account number
        public int AccountNumber
        {
            get { return accountNumber; }
        }
    }
}
