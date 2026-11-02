using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Make = "Maybach";
            vehicle.Year = 2024;
            Console.WriteLine("===Displaying vehicle details===");
            vehicle.display();
            Console.WriteLine();
            Car car = new Car();
            car.Make = "Toyota";
            car.Year = 2025;
            car.NumberOfDoors = 4;
            Console.WriteLine("===Displaying car details");
            car.display();

            Console.ReadKey();
        }
    }
}
