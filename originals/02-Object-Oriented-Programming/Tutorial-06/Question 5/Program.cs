using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Regular Order ===");
            Order order = new Order();

            Console.Write("Enter Customer Name: ");
            order.CustomerName = Console.ReadLine();

            Console.Write("Enter Customer Number: ");
            order.CustomerNumber = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            order.QuantityOrdered = int.Parse(Console.ReadLine());

            Console.Write("Enter Unit Price: ");
            order.UnitPrice = double.Parse(Console.ReadLine());

            order.DisplayOrder();
            Console.WriteLine();

            Console.WriteLine("=== Shipped Order ===");
            ShippedOrder shippedOrder = new ShippedOrder();

            Console.Write("Enter Customer Name: ");
            shippedOrder.CustomerName = Console.ReadLine();

            Console.Write("Enter Customer Number: ");
            shippedOrder.CustomerNumber = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            shippedOrder.QuantityOrdered = int.Parse(Console.ReadLine());

            Console.Write("Enter Unit Price: ");
            shippedOrder.UnitPrice = double.Parse(Console.ReadLine());
            shippedOrder.DisplayOrder();
            Console.WriteLine("Shipping Charge: R4.00");
            Console.WriteLine("Final Total: R"+ shippedOrder.ComputeTotalPrice().ToString("F2"));
            Console.ReadKey();
        }
    }
}
