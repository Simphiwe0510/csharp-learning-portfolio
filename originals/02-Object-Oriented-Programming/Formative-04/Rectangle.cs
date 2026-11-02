using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _[STUDENT_ID_REDACTED]_Student_Formative_4
{
    class Rectangle
    {
        protected double length;
        protected double width;

        public Rectangle()
        {
            length = 0.0;
            width = 0.0;
        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public virtual double computePerimeter()
        {
            return 2 * (length + width);
        }
        public virtual bool isSquare()
        {
            if(length == width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual void display()
        {
            Console.WriteLine("Length: "+ length);
            Console.WriteLine("Width: "+ width);
            Console.WriteLine("Perimeter: "+ computePerimeter());
            Console.WriteLine("Is a square: "+ isSquare());
        }
    }
}
