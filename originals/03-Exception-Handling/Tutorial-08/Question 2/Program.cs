using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter an integer representing the number of products in a store inventory: ");
                int productCount = int.Parse(Console.ReadLine());
                if (productCount < 0)
                {
                    productCount = 3;
                    Console.WriteLine("Product count was set to 3 because the input provided was less than zero");
                }
                decimal[] productPrice = new decimal[productCount];
                decimal total = 0;
                for (int i = 0; i < productCount; i++)
                {
                    Console.Write("Enter price for product "+(i+1)+":");
                    productPrice[i] = decimal.Parse(Console.ReadLine());
                    total += productPrice[i];
                }
                Console.WriteLine("Total cost of all products: "+ total);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error: "+ e.Message);
            }
           Console.ReadKey();
        }
    }
}
