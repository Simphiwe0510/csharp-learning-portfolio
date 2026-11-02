using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class CorporateSubscriber:Subscriber
    {
        private string companyName;
        private double amountPaid;

        public CorporateSubscriber()
        {
            this.companyName = string.Empty;
            this.amountPaid = 0.0;
        }
        public void setSubscriber(int id, double monthlyFee,string companyName,double amountPaid)
        {
            
            this.companyName = companyName;
            this.amountPaid = amountPaid;
        }
        public override void displaySubscriber()
        {
            base.displaySubscriber();
            Console.WriteLine("Company Name: "+ companyName);
            Console.WriteLine("Amount paid: "+ amountPaid);
            calcAnnualPayment();


        }
        public override void calcAnnualPayment()
        {
            double annualPayment = 0;
            annualPayment = monthlyFee * 12;
            double annualFeeDue = 0;
            annualFeeDue = annualPayment + 0.05;
            Console.WriteLine("Annual Fee Due: "+ annualPayment);
        }
        public void determineSufficientPayment(double annualPayment)
        {
            if (annualPayment > amountPaid)
            {
                Console.WriteLine("Status: Insufficient Payment");
            }
            else
                Console.WriteLine("Status: Payment done");
        }
    }
}
