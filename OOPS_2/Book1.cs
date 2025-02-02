using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Book1
    {
        //Attributes
        public string ISBN;
        protected string title;
        private string author;

        //Constructor
        public Book1(string ISBN, string title, string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }

        //setter for author
        public void setAuthor(string newAuthor)
        {
            author = newAuthor;
        }

        //getter for author
        public string getAuthor()
        {
            return author;
        }

        //displaying the data
        public virtual void DisplayDetails()
        {
            Console.WriteLine("The ISBN of the book is " + ISBN);
            Console.WriteLine("The title of the book is " + title);
            Console.WriteLine("The author of the book is " + author);
        }
    }

    class EBook : Book1 {
        public EBook(string ISBN, string title, string author) : base(ISBN,title,author) {
            
        }

        public void updateISBN() {
            Console.WriteLine("Enter the new ISBN");
            ISBN = Console.ReadLine();
        }

        public void updateTitle() {
            Console.WriteLine("Enter the new title");
            title = Console.ReadLine();
        }

        public override void DisplayDetails() {
            base.DisplayDetails();
        }
    }

    class program12
    {
        //public static void Main(String[] args)
        //{
        //    Book1 book1 = new Book1("1234-5678-9123", "title of book", "name of author");
        //    book1.DisplayDetails();

        //    book1.setAuthor("harry");
        //    book1.DisplayDetails();

        //    EBook ebook1 = new EBook("1234-5678-0000", "titlee", "authorr");
        //    ebook1.DisplayDetails();
        //    ebook1.updateISBN(); //accessing through sub class
        //    ebook1.DisplayDetails();
        //    ebook1.updateTitle(); //accessing through sub class
        //    ebook1.DisplayDetails();
        //}
    }
}
