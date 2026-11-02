using System;
using System.IO;
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
            string fileName = "story.txt";
            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, "This is a simple story.I like juice juice");
            }
            
            Console.Write("Enter the word to search: ");
            string word = Console.ReadLine();

            FileSearcher searcher = new FileSearcher();
            int found = searcher.SearchWord(fileName, word);

            Console.WriteLine("The word \"" + word + "\" appears " + found + " times.");
            Console.ReadKey();
        }
    }
    
}
