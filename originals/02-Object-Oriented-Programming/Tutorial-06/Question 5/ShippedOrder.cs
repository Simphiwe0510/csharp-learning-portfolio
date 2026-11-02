using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class ShippedOrder:Order
    {
        public override double ComputeTotalPrice()
        {
            return 4.0 + QuantityOrdered * UnitPrice;
        }  
       
    }
}
