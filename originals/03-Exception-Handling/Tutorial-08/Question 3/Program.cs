using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a string representing a number: ");
                int input = int.Parse(Console.ReadLine());
                double divide = (double)100/input;
                Console.WriteLine("100 divided by input: "+ divide);
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter a valid number(digit)");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter a smaller number");
            }
            catch(DivideByZeroException )
            {
                Console.WriteLine("Division by zero is not allowed");
            }

        }
    }
}
