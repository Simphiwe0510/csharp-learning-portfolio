using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    abstract class Subscriber
    {
        protected int id;
        protected double monthlyFee;

        public Subscriber()
        {
            this.id = 0;
            this.monthlyFee = 0.0;
        }
        public void setSubscriber(int id,double monthlyFee)
        {
            this.id = id;
            this.monthlyFee = monthlyFee;
        }
        public virtual void displaySubscriber()
        {
            Console.WriteLine("Subscriber ID: "+ id);
            Console.WriteLine("Subscriber monthly fee: "+ monthlyFee);
        }
        public abstract void calcAnnualPayment();

    }
}
