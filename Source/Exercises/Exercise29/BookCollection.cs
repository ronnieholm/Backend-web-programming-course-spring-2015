using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise29
{
    class Runner
    {
        public void Run()
        {
            Book b1 = new Book("AD1337", "Java for All", "John Potter", 352);
            Book b2 = new Book("XS3220", "Gardening", "Alex Sohn", 220);
            Book b3 = new Book("DD0095", "Cars in the USA", "Susan Dreyer", 528);
            Book b4 = new Book("PT1295", "Copenhagen Dawn", "Dan Mygind", 104);

            BookCollection books = new BookCollection();
            books.AddBook(b1);
            books.AddBook(b2);
            books.AddBook(b3);
            books.AddBook(b4);

            Console.WriteLine("------------- Printing all books ---------------");
            books.PrintAllBooks();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            SafePrintBookInformation(books.LookupBook("AD1337"));
            SafePrintBookInformation(books.LookupBook("AD1338"));
            SafePrintBookInformation(books.LookupBook("PT1295"));
            SafePrintBookInformation(books.LookupBook("......"));
            SafePrintBookInformation(books.LookupBook("ad1337"));
        }

        public void SafePrintBookInformation(Book book)
        {
            if (book == null)
            {
                Console.WriteLine("Book was null...");
            }
            else
            {
                Console.WriteLine(book.GetAllInformation());
            }
        }
    }

    class BookCollection
    {
        private List<Book> _books;

        public BookCollection()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            // add code to add book object to list
        }

        public void PrintAllBooks()
        {
            // add code to print books in list.
            // Hint: you will need a repetition statement.
        }

        public Book LookupBook(string isbn)
        {
            Book match = null;

            // add code to find book (if any) in list with matching ISBN 
            // number. The match variable should be set to the book found.
            // Hint: You will need a repetition statement.

            return match;
        }
    }
}
