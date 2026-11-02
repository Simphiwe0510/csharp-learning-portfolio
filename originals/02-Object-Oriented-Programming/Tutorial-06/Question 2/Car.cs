using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Car:Vehicle
    {
        private int numberOfDoors;

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set { numberOfDoors = value; }
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("Number of doors: "+ NumberOfDoors);
        }
    }
}
