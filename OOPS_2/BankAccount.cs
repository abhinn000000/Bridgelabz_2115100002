using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class BankAccount
    {
        //Attributes
        public int accountNumber;
        protected string accountHolder;
        private double accountBalance;

        //Constructor
        public BankAccount(int accountNumber, string accountHolder, double accountBalance) {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.accountBalance = accountBalance;
        }
        //updating the balance
        public void updateBalance() {
            Console.WriteLine("Enter the new balance");
            accountBalance = Convert.ToDouble(Console.ReadLine());
        }

        //Displaying the details
        public virtual void DisplayDetails()
        {
            Console.WriteLine("The account number is " + accountNumber);
            Console.WriteLine("The account holder is " + accountHolder);
            Console.WriteLine("The account balance is " + accountBalance);
        }
    }

    class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accountNumber, string accountHolder, double accountBalance) : base(accountNumber, accountHolder, accountBalance)
        {

        }

        public void updateAccountNumber()
        {
            Console.WriteLine("Enter the new account number");
            accountNumber = Convert.ToInt32(Console.ReadLine());
        }

        public void updateAccountHolder()
        {
            Console.WriteLine("Enter the new account holder");
            accountHolder = Console.ReadLine();
        }

        public void DisplayDetails() {
            base.DisplayDetails();
        }

    }

    class program13
    {
        //public static void Main(String[] args)
        //{
        //    BankAccount account1 = new BankAccount(789, "Akhil", 80000);
        //    account1.DisplayDetails();

        //    SavingsAccount account2 = new SavingsAccount(654,"Jack",150000);
        //    account2.DisplayDetails();
        //    account2.updateBalance(); // accessing balance in sub class
        //    account2.DisplayDetails();
        //    account2.updateAccountHolder(); // accessing account holder in sub class
        //    account2.DisplayDetails();
        //}
    }
}
