using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Order
    {
        private string customerName;
        private string customerNumber;
        private int quantityOrdered;
        private double unitPrice;

        public string CustomerName
        {
            get { return customerName; } 
            set { customerName = value; }
        }
        public string CustomerNumber
        {
            get { return customerNumber; } 
            set { customerNumber = value; }
        }
        public int QuantityOrdered
        {
            get { return quantityOrdered; } 
            set { quantityOrdered = value; }
        }
        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        public virtual double ComputeTotalPrice()
        {
            double totalPrice = QuantityOrdered * UnitPrice;
            return totalPrice;
        }
        public void DisplayOrder()
        {
            Console.WriteLine("Customer name: "+ CustomerName);
            Console.WriteLine("Customer number: "+ CustomerNumber);
            Console.WriteLine("Quantity ordered: "+ QuantityOrdered);
            Console.WriteLine("Unit price: "+ UnitPrice);
            Console.WriteLine("Total price: "+ ComputeTotalPrice().ToString("F2"));
        }




    }
}
