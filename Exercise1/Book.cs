using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Book
    {
        public string? BookName { get; set; }
        public int ISBN { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }

        public Book(string? bookName, int isbn, string? author, string? publisher)
        {
            BookName = bookName;
            ISBN = isbn;
            Author = author;
            Publisher = publisher;
        }

        public Book() { }


        // method

        public string GetBookInformation()
        {
            return "Book Name: " + this.BookName + "\tISBN: " + this.ISBN + "\tAuthor: " + this.Author + "\tPublisher: " + this.Publisher;
        }
    }
}
