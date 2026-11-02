using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Radius = 10;
            Console.WriteLine("===Circle details====");
            Console.WriteLine("Surface area for circle: "+ circle.ComputeSurfaceArea().ToString("F2"));
            Console.WriteLine();
            Sphere sphere = new Sphere();
            sphere.Radius = 20;
            Console.WriteLine("===Sphere details===");
            Console.WriteLine("Surface area for sphere: "+ sphere.ComputeSurfaceArea().ToString("F2"));


            Console.ReadKey();
        }
    }
}
