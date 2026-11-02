using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _[STUDENT_ID_REDACTED]_Student_Formative_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productName = { "Laptop", "Phone", "empty", "Tablet", "Monitor" };
            int[] quantity = { 10, -5, 8, 3, 0 };
            double[] price = { 17999.99, 5000.00, 1200.00, 0.00, 250.00 };

            Product[] products = new Product[5];
            for(int i =0; i < products.Length;i++)
            {
                try
                {
                    products[i] = new Product(productName[i], quantity[i], price[i]);
                }
                catch(ProductException ex)
                {
                    products[i] = new Product();
                    Console.WriteLine("Error creating product #"+(i+1)+":" +ex.Message);
                }
            }
            Console.WriteLine("===Product Inventory===");
            for(int i =0; i < products.Length;i++)
            {
                Console.WriteLine("Product: "+ products[i].ToString()); 
                Console.WriteLine("Total Value: "+ products[i].TotalValue());
            }

            Console.Write("Enter the amount of increase: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the percentage to take off from price: ");
            double percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Applying changes to product #1");
            Console.WriteLine("Updated product #1");
            Console.WriteLine("Product: "+ products[0], quantity[0], "Price"+ price[0]);
            
            Console.ReadKey();
        }
    }
}
