using System;
namespace BankAccount_Functions
{
    //Class Bank with bank services methods
    internal class Bank
    {
        private static string bankName;
        private const double minimumBalance = 2000;

        //set method for bank name
        public string BankName
        {
            set { bankName = value; }
        }

        // taking bank name as input from the user
        public Bank()
        {
            Console.Write("Please Enter the Bank's Name: ");
            bankName = Console.ReadLine();
            Console.WriteLine("Welocome to " + bankName + " Bank!");
        }

        //Deposit function
        public void Deposit(double amount, Customer customer)
        {
            if (amount > 0)
            {
                customer.CurrentBalance += amount;
                Console.WriteLine("You have successfully deposited " + amount + " Rupees. Now Your Current Balance is " + customer.CurrentBalance);
            }
            else
            {
                Console.WriteLine("Invalid Amount input.");
            }
        }

        //Withdraw function
        public void Withdraw(double amount, Customer customer)
        {
            double checkBalance = customer.CurrentBalance - amount;
            if (checkBalance >= minimumBalance)
            {
                customer.CurrentBalance = checkBalance;
                Console.WriteLine("Successful Withdrawal of " + amount + " Rupees. Current balance is " + customer.CurrentBalance);
            }
            else
            {
                Console.WriteLine("Can't Withdraw " + amount + " Rupees. Minimimum amount to hold in the Account is " + minimumBalance);
            }
        }
        public void CheckBalance(Customer customer)
        {
            Console.WriteLine("Your Current Balance is " + customer.CurrentBalance + " Rupees.");
        }
    }
}
