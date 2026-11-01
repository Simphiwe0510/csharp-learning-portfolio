using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Book
    {
        private string title;
        private int numberOfPages;

        public Book()
        {
            title = "Untitled";
            numberOfPages = 0;
        }

        public Book(string title, int numberOfPages)
        {
            this.title = title;
            this.numberOfPages = numberOfPages;
        }

        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        public int NumberOfPages
        {
            set { numberOfPages = value; }
            get { return numberOfPages; }
        }

        public virtual void display()
        {
            Console.WriteLine("Title: "+ title);
            Console.WriteLine("Number of pages: " + numberOfPages);
        }
    }
}
