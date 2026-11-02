using System;
using System.IO;
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
            StudentManager manager = new StudentManager();
            string file = "students.txt";

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Save to File");
                Console.WriteLine("3. Clear Current List");
                Console.WriteLine("4. Load from File and Display");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Student s = new Student();
                    Console.Write("Name: ");
                    s.Name = Console.ReadLine();
                    Console.Write("Test1: ");
                    s.Test1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Test2: ");
                    s.Test2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Test3: ");
                    s.Test3 = Convert.ToDouble(Console.ReadLine());
                    manager.addStudent(s);
                }
                else if (choice == "2")
                {
                    manager.saveToFile(file);
                    Console.WriteLine("Saved!");
                }
                else if (choice == "3")
                {
                    manager = new StudentManager();
                    Console.WriteLine("List cleared!");
                }
                else if (choice == "4")
                {
                    manager.loadFromFile(file);
                    manager.displayStudents();
                }
                else if (choice == "5")
                {
                    break;
                }
            }
        }  
    }
}
