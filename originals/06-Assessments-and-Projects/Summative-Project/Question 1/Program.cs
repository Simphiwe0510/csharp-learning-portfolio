using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Gym Loyalty Voucher Tracker");
            while (true)
            {
                Console.Write("Enter member's name(or type 'exit' to stop:");
                string memberName = Console.ReadLine();
                int voucherRemaing = 340;

                if (memberName == "exit")
                {
                    Console.WriteLine();
                    Console.WriteLine("Program ended by user");
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using the Gym Loyalty Voucher Trracker");
                    break;
                    
                }
                
                else
                {
                    Console.Write("Enter number of sessions attended: ");
                    int numberOfSeesssions = int.Parse(Console.ReadLine());
                    double voucherValue = 0;

                    if (numberOfSeesssions >= 5 && numberOfSeesssions <= 10)
                    {
                        voucherValue = numberOfSeesssions * 8;
                        voucherRemaing-=1;
                    }

                    else if (numberOfSeesssions >= 11 && numberOfSeesssions <= 20)
                    {
                        voucherValue = numberOfSeesssions * 10.50;
                        voucherRemaing-=1;

                    }
                    else if (numberOfSeesssions >= 21 && numberOfSeesssions <= 40)
                    {
                        voucherValue = numberOfSeesssions * 13;
                        voucherRemaing-=1;

                    }
                    else
                        voucherValue = numberOfSeesssions * 16;
                        voucherRemaing-=1;


                    Console.WriteLine("\n=== Voucher Summary=== ");
                    Console.WriteLine("Member Name: " + memberName);
                    Console.WriteLine("Sessions Attended: " + numberOfSeesssions);
                    Console.WriteLine("Voucher Value: R" + voucherValue.ToString("F2"));
                    Console.WriteLine("Vouchers Remaining: "+ voucherRemaing);
                    Console.WriteLine();
                }

            }
            Console.ReadKey();
        }
    }
}
