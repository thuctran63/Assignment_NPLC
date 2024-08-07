using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Book
    {
        private string? BookName;
        private int ISBN;
        private string? Author;
        private string? Publisher;

        public Book(string? bookName, int isbn, string? author, string? publisher)
        {
            BookName = bookName;
            ISBN = isbn;
            Author = author;
            Publisher = publisher;
        }


        // method

        public string GetBookInformation()
        {
            return "Book Name: " + this.BookName + "\tISBN: " + this.ISBN + "\tAuthor: " + this.Author + "\tPublisher: " + this.Publisher;
        }
    }
}
