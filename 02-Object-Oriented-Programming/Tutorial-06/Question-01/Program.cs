using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Shaka",65);
            Console.WriteLine("===Display the book===");
            book.display();
            Console.WriteLine();
            TextBook textBook = new TextBook("Ilembe",264,"Grade 12");
            Console.WriteLine("===Display textbook===");
            textBook.display();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
