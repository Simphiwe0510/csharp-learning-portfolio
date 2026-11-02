using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _[STUDENT_ID_REDACTED]_Student_Formative_5
{
    class Product
    {
        private string name;
        private int quantity;
        private double price;
        public Product()
        {
            name = string.Empty;
            quantity = 0;
            price = 0;
        }
        public Product(string name, int quantity, double price)
        {
            if (name == null || name == string.Empty)
            {
                throw new ProductException("The product name is null or empty");
            }
            else if (quantity < 0)
            {
                throw new ProductException("The quantity can not negative");
            }
            else if(price <=0)
            {
                throw new ProductException("The price must be greater zero");
            }
        }
        public override string ToString()
        {
            return "Product name " + name + "Quantity of product " + quantity + "Price of product "+ price; 
        }
        public void IncreaseStock(int amount)
        {
            if(amount < 0)
            {
                throw new ProductException("Amount must be greater than 0");
            }
            else
            quantity += amount;
        }
        public void ApplyDiscount(double percent)
        {
            percent = (percent / 100);
            if (percent < 0 || percent > 100)
            {
                throw new ProductException("Percentage is less than or greater than 100");
            }
            else

                price = price - (price*percent);
        }
        public double TotalValue()
        {
            return quantity * price;
        }
    }
}
