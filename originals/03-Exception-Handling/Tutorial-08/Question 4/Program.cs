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
            string[] departments = new string[6];
            int[] numbers = new int[6];
            int[] credits = new int[6];
            Course[] courses = new Course[6];

            for (int i = 0; i < 6; i++)
            {
                    Console.WriteLine("Enter department for course " + (i + 1) + ": ");
                    departments[i] = Console.ReadLine();
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter course number for course " + (i + 1) + ": ");
                            numbers[i] = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number.");
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter number of credits for course " + (i + 1) + ": ");
                            credits[i] = int.Parse(Console.ReadLine());
                            break; 
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number of credits.");
                        }
                    }

                try
                {
                    courses[i] = new Course(departments[i], numbers[i], credits[i]);
                }
                catch (CourseException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Using default course instead");
                    courses[i] = new Course();
                }
                Console.WriteLine();
            }
            Console.WriteLine("All courses created:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(courses[i].ToString());
            }

            Console.ReadKey();
        }
    }
}
