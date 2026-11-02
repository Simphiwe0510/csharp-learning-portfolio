using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _[STUDENT_ID_REDACTED]_Student_Formative_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rectangles = new Rectangle[4];
            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter lenght: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            for (int x = 0; x < rectangles.Length; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("\nRectangle: ");
                    Rectangle rectangle = new Rectangle(length,width);
                    rectangle.display();
                }
                else
                {
                    Console.WriteLine("\nBoxes: ");
                    Box boxes = new Box(length, width,height);
                    boxes.display();
                }
               
            }
            Console.ReadKey();
        }
    }
}
