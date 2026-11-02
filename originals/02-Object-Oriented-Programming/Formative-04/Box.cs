using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _[STUDENT_ID_REDACTED]_Student_Formative_4
{
    class Box:Rectangle
    {
        private double height;

        public Box():base()
        {
            height = 0.0;
        }
        public Box(double length,double width, double height):base(length,width)
        {
            this.height = height;
        }
        public override double computePerimeter()
        {
            return 4 * (length + width + height);
        }
        public override bool isSquare()
        {
            if(length == height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void display()
        {
            Console.WriteLine("Height: "+ height);
            base.display();
        }
    }
}
