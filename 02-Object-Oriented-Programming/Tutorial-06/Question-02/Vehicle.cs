using System;
namespace Question_2
{
    internal class Vehicle
    {
        private string make;
        private int year;
        public string Make { get { return make; } set { make = value; } }
        public int Year { get { return year; } set { year = value; } }
        public virtual void display()
        {
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Year: " + Year);
        }
    }
}
