using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Square
    {
        private double height;
        private double width;

        public double Height
        { 
            get { return height; }
            set { height = value; }
        }
        public double Width
        {
            get { return width; } 
            set { width = value; }
        }
        public virtual double computeSurfaceArea()
        {
            return height * width;
        }
        public virtual void display()
        {
            Console.WriteLine("Surface area: "+ computeSurfaceArea());
        }
    }
}
