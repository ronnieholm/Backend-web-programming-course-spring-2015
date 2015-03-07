using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise29
{
    class Book
    {
        private string _isbn;
        private string _title;
        private string _author;
        private int _numberOfPages;

        public Book(string isbn, string title, string author, int numberOfPages)
        {
            _isbn = isbn;
            _title = title;
            _author = author;
            _numberOfPages = numberOfPages;
        }

        public string GetISBN()
        {
            return _isbn;
        }

        public string GetAllInformation()
        {
            return "ISBN: " + _isbn + ", \"" + _title + "\", by " + _author + " (" + _numberOfPages + " pages)";
        }
    }
}
