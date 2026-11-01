using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 11);
            }
            Console.Write("Array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int foundIndex = -1;
            Console.Write("Enter search value: ");
            int searchValue = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchValue)
                {
                    foundIndex = i;
                    break;
                }
            }
            Console.WriteLine("Index found: " + foundIndex);
            Console.ReadKey();
        }
    }
}
