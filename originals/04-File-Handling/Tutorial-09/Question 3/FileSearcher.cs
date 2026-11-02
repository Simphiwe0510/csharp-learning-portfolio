using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class FileSearcher
    {
        public int SearchWord(string filePath, string word)
        {
            int count = 0;

            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    string lowerLine = line.ToLower();
                    string lowerWord = word.ToLower();
                    string[] words = lowerLine.Split(' ');
                    foreach (string w in words)
                    {
                        if (w == lowerWord)
                        {
                            count++;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found!");
            }

            return count;
        }
    }
}
