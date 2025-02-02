using MyFirstProject;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstProject
{
    internal class Book
    {   //Attrbutes
        private string title;
        private string author;
        private int availability;
        private int price;

        //Constructor
        public Book(string title, string author, int price,int availability)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.availability = availability;
        }

        //Default Constructor
        public Book()
        {
            title = "No Title available";
            author = "No author available";
            price = 0;
            availability = 0;
        }

        //Borrowing a book
        public void BorrowBook() {
            if (availability == 0)
            {
                Console.WriteLine("Sorry, you cannot borrow this book. As they are out of stock.");
            }
            else {
                Console.WriteLine("Thanks for borrowing the book!");
                availability--;
            }
        }

        //Displaying the details
        public void DisplayDetails()
        {
            Console.WriteLine("The title of the book is " + title);
            Console.WriteLine("The author of the book is " + author);
            Console.WriteLine("The price of the book is " + price);
            Console.WriteLine("The number of remaining books is " + availability);
        }
    }

    class program2
    {
        //public static void Main(String[] args)
        //{
        //    Book book1 = new Book("A Song of Ice and Fire", "George R.R. Martin", 68,4);
        //    Book book2 = new Book();
        //    book1.DisplayDetails();
        //    book2.DisplayDetails();
        //    book1.BorrowBook();
        //}
    }
}

