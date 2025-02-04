using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Library
    {
        private static string LibraryName = "Jain Library";
        private string title;
        private string author;
        private readonly int ISBN;

        //Constructor
        public Library(string title, string author, int ISBN) {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }

        public static void DisplayLibraryName() {
            Console.WriteLine("The name of the Library is " + LibraryName);
        }

        //displaying details
        public void DisplayDetails()
        {
            if (this is Library)
            {
                Console.WriteLine("The title of the book is " + title);
                Console.WriteLine("The author of the book is " + author);
                Console.WriteLine("The ISBN of the book is " + ISBN);
            }
        }

    }

    class program16{
        //public static void Main(String[] args) {
        //    Library.DisplayLibraryName();
        //    Library book1 = new Library("A song of ice and fire","George RR Martin",8907);
        //    book1.DisplayDetails();

        //}
    }
}
