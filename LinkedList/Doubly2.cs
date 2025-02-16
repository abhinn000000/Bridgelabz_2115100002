using System;

class BookNode
{
    public string BookTitle { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int BookID { get; set; }
    public bool IsAvailable { get; set; }
    public BookNode Next { get; set; }
    public BookNode Prev { get; set; }

    public BookNode(string bookTitle, string author, string genre, int bookId, bool isAvailable)
    {
        BookTitle = bookTitle;
        Author = author;
        Genre = genre;
        BookID = bookId;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

class LibraryManagement
{
    private BookNode head;
    private BookNode tail;

    public LibraryManagement()
    {
        head = null;
        tail = null;
    }

    public void AddBookAtStart(string bookTitle, string author, string genre, int bookId, bool isAvailable)
    {
        BookNode newNode = new BookNode(bookTitle, author, genre, bookId, isAvailable);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
        Console.WriteLine("Book added at the start.");
    }

    public void AddBookAtEnd(string bookTitle, string author, string genre, int bookId, bool isAvailable)
    {
        BookNode newNode = new BookNode(bookTitle, author, genre, bookId, isAvailable);
        if (tail == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
        Console.WriteLine("Book added at the end.");
    }

    public void AddBookAtPosition(string bookTitle, string author, string genre, int bookId, bool isAvailable, int position)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        BookNode newNode = new BookNode(bookTitle, author, genre, bookId, isAvailable);
        if (position == 1)
        {
            AddBookAtStart(bookTitle, author, genre, bookId, isAvailable);
            return;
        }

        BookNode current = head;
        int count = 1;

        while (current != null && count < position - 1)
        {
            current = current.Next;
            count++;
        }

        if (current == null)
        {
            Console.WriteLine("Position out of bounds.");
            return;
        }

        newNode.Next = current.Next;
        newNode.Prev = current;

        if (current.Next != null)
        {
            current.Next.Prev = newNode;
        }
        else
        {
            tail = newNode;
        }
        current.Next = newNode;

        Console.WriteLine("Book added at position " + position + ".");
    }

    public void RemoveBookById(int bookId)
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        BookNode current = head;

        while (current != null && current.BookID != bookId)
        {
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (current.Prev != null)
        {
            current.Prev.Next = current.Next;
        }
        else
        {
            head = current.Next;
        }

        if (current.Next != null)
        {
            current.Next.Prev = current.Prev;
        }
        else
        {
            tail = current.Prev;
        }

        Console.WriteLine("Book removed.");
    }

    public void SearchByTitle(string bookTitle)
    {
        BookNode current = head;
        while (current != null)
        {
            if (current.BookTitle.Equals(bookTitle, StringComparison.OrdinalIgnoreCase))
            {
                PrintBook(current);
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Book not found.");
    }

    public void SearchByAuthor(string author)
    {
        BookNode current = head;
        while (current != null)
        {
            if (current.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                PrintBook(current);
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Book not found.");
    }

    public void UpdateAvailabilityStatus(int bookId, bool isAvailable)
    {
        BookNode current = head;
        while (current != null)
        {
            if (current.BookID == bookId)
            {
                current.IsAvailable = isAvailable;
                Console.WriteLine("Availability status updated.");
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Book not found.");
    }

    public void DisplayBooksForward()
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        BookNode current = head;
        while (current != null)
        {
            PrintBook(current);
            current = current.Next;
        }
    }

    public void DisplayBooksReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        BookNode current = tail;
        while (current != null)
        {
            PrintBook(current);
            current = current.Prev;
        }
    }

    public void CountTotalBooks()
    {
        int count = 0;
        BookNode current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        Console.WriteLine("Total number of books: " + count);
    }

    private void PrintBook(BookNode book)
    {
        Console.WriteLine("Title: " + book.BookTitle + ", Author: " + book.Author + ", Genre: " + book.Genre + ", ID: " + book.BookID + ", Available: " + (book.IsAvailable ? "Yes" : "No"));
    }
}

class Program
{
    static void Main()
    {
        LibraryManagement library = new LibraryManagement();

        library.AddBookAtEnd("The Great Gatsby", "F. Scott Fitzgerald", "Classic", 101, true);
        library.AddBookAtEnd("To Kill a Mockingbird", "Harper Lee", "Fiction", 102, true);
        library.AddBookAtStart("1984", "George Orwell", "Dystopian", 103, true);
        library.AddBookAtPosition("Moby Dick", "Herman Melville", "Adventure", 104, false, 2);

        Console.WriteLine("Books in forward order:");
        library.DisplayBooksForward();

        library.RemoveBookById(102);
        Console.WriteLine("After removing book with ID 102:");
        library.DisplayBooksForward();

        library.UpdateAvailabilityStatus(101, false);
        Console.WriteLine("After updating availability status of book with ID 101:");
        library.DisplayBooksForward();

        Console.WriteLine("Searching for book by title '1984':");
        library.SearchByTitle("1984");

        Console.WriteLine("Books in reverse order:");
        library.DisplayBooksReverse();

        library.CountTotalBooks();
    }
}