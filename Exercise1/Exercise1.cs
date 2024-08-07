using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Exercise1
    {
        public static void main()
        {
            Book book = new Book();

            Console.WriteLine("Enter ISBN : ");
            book.ISBN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter book name: ");
            book.BookName = Console.ReadLine();
            Console.WriteLine("Enter author name: ");
            book.Author = Console.ReadLine();
            Console.WriteLine("Enter publisher: ");
            book.Publisher = Console.ReadLine();

            Console.WriteLine("Information book: ");
            Console.WriteLine(book.ToString());

        }
    }
}
