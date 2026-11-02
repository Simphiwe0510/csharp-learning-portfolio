using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Sphere:Circle
    {
        public override double ComputeSurfaceArea()
        {
            return 4 * Math.PI * Radius * Radius;
        }
    }
}
