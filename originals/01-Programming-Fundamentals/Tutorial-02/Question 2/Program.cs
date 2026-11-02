using System;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] quantity = new int[2];
            string[] names = new string[2];
            double[] price = new double[2];
            double[] stockValue = new double[2];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter product name: ");
                names[i] = Console.ReadLine();
                quantity[i] = rand.Next(1, 51);
                Console.Write("Enter product price: ");
                price[i] = Convert.ToDouble(Console.ReadLine());

                stockValue[i] = quantity[i] * price[i];
            }
            Console.WriteLine("Product Name \t Quantity \t Price \t StockValue");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + "\t\t" + quantity[i] + "\t\t" +  "R" + price[i].ToString("F2") + "\t\t" +
                                  "R" + stockValue[i].ToString("F2"));
            }
            Console.ReadKey();
        }
    }
}
