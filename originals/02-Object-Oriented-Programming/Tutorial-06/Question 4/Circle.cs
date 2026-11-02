using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Circle
    {
        private double radius;

        public double Radius 
        {
            get { return radius; }
            set { radius = value; } 
        }

        public virtual double ComputeSurfaceArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
