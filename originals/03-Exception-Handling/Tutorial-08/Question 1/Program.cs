using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentScores = {50,74,98,63,38};
            try
            {
                Console.Write("Enter an integer representing the index of a score(0–4): ");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("Student score: "+ studentScores[input]);
            }
            catch(IndexOutOfRangeException e) 
            {
                Console.WriteLine("Error: "+ e.Message);
            }

          Console.ReadKey();    

        }
    }
}
