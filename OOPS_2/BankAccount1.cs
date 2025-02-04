using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class BankAccount1
    {
        //Attributes
        private static string bankName ="Ravi bank";
        private static int TotalAccounts = 0;
        private string AccountHolderName;
        private readonly int AccountNumber;

        //Constructor
        public BankAccount1(string AccountHolderName, int AccountNumber)
        {
            this.AccountHolderName = AccountHolderName;
            this.AccountNumber = AccountNumber;
            TotalAccounts++;
        }

        //Get total number of accounts
        public int GetTotalAccounts()
        {
            return TotalAccounts;
        }

        //DisplayDetails
        public void DisplayDetails()
        {   
            if (this is BankAccount1) //checking if it's an object
            {
                Console.WriteLine("The name of the Bank is " + bankName);
                Console.WriteLine("The total number of accounts is " + GetTotalAccounts());
                Console.WriteLine("The name of the account holder is " + AccountHolderName);
                Console.WriteLine("The account number is " + AccountNumber);
            }
            
        }

    }

    class program15
    {
        //public static void Main(String[] args)
        //{
        //    BankAccount1 account1 = new BankAccount1("Akshay", 7890);
        //    account1.DisplayDetails();
        //    BankAccount1 account2 = new BankAccount1("Vatsal", 7890);
        //    account2.DisplayDetails();
        //}
        
    }
}
