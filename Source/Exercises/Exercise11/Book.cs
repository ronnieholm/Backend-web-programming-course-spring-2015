using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise11
{
    // begin copy
    class Book
    {
        // instance fields
        private string _isbnCode;
        private string _title;
        private string _author;
        private double _price;
        private bool _bookIsLoanedOut;

        // constructor
        public Book(string isbnCode, string title, string author, double price)
        {
            this._isbnCode = isbnCode;
            this._title = title;
            this._author = author;
            this._price = price;
            this._bookIsLoanedOut = false;
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
        }

        public void ReturnToLibrary()
        {
            _bookIsLoanedOut = false;
        }

        // prints out information about the book
        public void PrintInformation()
        {
            Console.WriteLine("ISBN {0} : {1}, by {2}  (price {3})", _isbnCode, _title, _author, _price);
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
    // end copy
}