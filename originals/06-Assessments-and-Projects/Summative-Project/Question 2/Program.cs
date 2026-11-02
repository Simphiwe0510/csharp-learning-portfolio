using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CorporateSubscriber[] corporateSubscribers = new CorporateSubscriber[6];
            int[] id = { 201, 202, 203, 204, 205 }; 
            double[] monthlyFee = { 200, 500, 750, 300, 450 };
            string[] companyName = { "Alpha", "Beta Media", "CyberTech", "Delta Digital", "Echo Entertainment"};
            double[] amountPaid = { 2600, 7000, 9000, 3500, 5000 };

            for(int i =0;i < corporateSubscribers.Length;i++)
            {
                corporateSubscribers[i] = new CorporateSubscriber();
                corporateSubscribers[i].setSubscriber(id[i],monthlyFee[i],companyName[i],amountPaid[i]);
            }
            for(int i = 0; i < corporateSubscribers.Length; i++)
            {
                corporateSubscribers[i].displaySubscriber();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
