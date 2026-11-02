using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class TextBook:Book
    {
        private string gradeLevel;

        public TextBook() : base()
        {
            gradeLevel = "Unknown";
        }

        public TextBook(string title, int numberOfPages, string gradeLevel) :
            base(title, numberOfPages)
        {
            this.gradeLevel = gradeLevel;

        }

        public string GradeLevel { set; get; }

        public override void display()
        {
            base.display();
            Console.WriteLine("Title: " + gradeLevel);
        }
    
    }
}
