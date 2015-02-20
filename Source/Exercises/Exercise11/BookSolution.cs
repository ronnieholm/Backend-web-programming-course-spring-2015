using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise11
{
    class MyCode
    {
        public void MyMain()
        {
            // 2a
            BookSolution b1 = new BookSolution("12345678", "SomeTitle", "SomeAuthor", 29.95);

            // 2b
            b1.PrintInformation();

            // 2c
            b1.BorrowFromLibrary();
            b1.PrintInformation();

            // 2d
            b1.ReturnToLibrary();
            b1.PrintInformation();

            // 4
            BookSolution b2 = new BookSolution("23456789", "SomeTitle", "SomeAuthor", 9.95);
            b2.PrintInformation();
            b2.BorrowFromLibrary();
            b2.PrintInformation();
        }
    }

    class BookSolution
    {
        // instance fields
        private string _isbnCode;
        private string _title;
        private string _author;
        private double _price;
        private bool _bookIsLoanedOut;

        // 3a
        private int numberOfLoans;

        // constructor
        public BookSolution(string isbnCode, string title, string author, double price)
        {
            _isbnCode = isbnCode;
            _title = title;
            _author = author;
            _price = price;
            _bookIsLoanedOut = false;

            // 3b
            numberOfLoans = 0;
        }

        // standard Get methods
        public string GetIsbnCode()
        {
            return _isbnCode;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public double GetPrice()
        {
            return _price;
        }

        public bool GetBookIsLoanedOut()
        {
            return _bookIsLoanedOut;
        }


        // the two methods below are supposed to be called when a user loans 
        // the book from the library and returns the book to the library.
        public void BorrowFromLibrary()
        {
            _bookIsLoanedOut = true;

            // 3c
            numberOfLoans++;
        }

        // 3d
        public int GetNumberOfLoans()
        {
            return numberOfLoans;
        }

        public void ReturnToLibrary()
        {
            _bookIsLoanedOut = false;
        }

        // prints out information about the book
        public void PrintInformation()
        {
            // 3e
            Console.WriteLine("ISBN {0} : {1}, by {2}  (price {3}) {4}", _isbnCode, _title, _author, _price, numberOfLoans);
            Console.WriteLine();
        }

        // helper method to make printing of book information look nicer. 
        // Don't worry about how the method works just yet.
        private string LoanStatus()
        {
            if (_bookIsLoanedOut)
            {
                return "book is loaned out";
            }
            else
            {
                return "book is NOT loaned out";
            }
        }
    }
}
