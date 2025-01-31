using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Books
    {   //Attrbutes
        private string title;
        private string author;
        private int price;

        //Constructor
        public Books(string title, string author, int price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        //Displaying the details
        public void DisplayDetails()
        {
            Console.WriteLine("The title of the book is " + title);
            Console.WriteLine("The author of the book is " + author);
            Console.WriteLine("The price of the book is " + price);
        }
    }

    class program {
        public static void Main(String[] args)
        {
            Books book1 = new Books("A Song of Ice and Fire", "George R.R. Martin", 68);
            book1.DisplayDetails();
        }
    }
}
