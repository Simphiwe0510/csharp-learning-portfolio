using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Height = 100;
            square.Width = 50;
            Console.WriteLine("===Square details===");
            Console.WriteLine("Surface area of square: " + square.computeSurfaceArea());
            Console.WriteLine();
            Cube cube = new Cube();
            cube.Height = 100;
            cube.Width = 50;
            cube.Depth = 30;
            Console.WriteLine("===Cube details===");
            Console.WriteLine("Surface area of cube: " + cube.computeSurfaceArea());
            
            Console.ReadKey();
        }
    }
}
