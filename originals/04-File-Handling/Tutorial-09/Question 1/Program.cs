using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string fileName = "movies.txt";

              
             Console.WriteLine("Enter your 3 favourite movies:");
             string[] movies = new string[3];
             for (int i = 0; i < 3; i++)
             {
                    Console.Write("Movie " + (i + 1) + ": ");
                    movies[i] = Console.ReadLine();
             }
            StreamWriter writer = new StreamWriter(fileName);
            foreach (string movie in movies)
            {
               writer.WriteLine(movie);
            }
                writer.Close();
            Console.WriteLine();
            Console.WriteLine("Your favourite movies are:");
            StreamReader reader = new StreamReader(fileName);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
               Console.WriteLine(line);
            }
                reader.Close();
        }
    }
}

