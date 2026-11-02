using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Cube:Square
    {
        private double depth;

        public double Depth
        {
            get {  return depth; }
            set { depth = value; }
        }
        public override double computeSurfaceArea()
        {
            return 2 * (Height * Width + Height * Depth  + Width * Depth);
        }
        public override void display()
        {
            Console.WriteLine("Surface area of cube: "+ computeSurfaceArea());
        }
    }
}
