using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of floors: ");
            int floorNumbers = int.Parse(Console.ReadLine());
            double[,] revenue = new double[floorNumbers, 7];
            PopulateRevenue(revenue);
            double[] dailyTotals = CalculateDailyRevenueTotals(revenue);
            Console.WriteLine("\nDaily revenue totals:");
            for (int i = 0; i < dailyTotals.Length; i++)
            {
                Console.WriteLine("Day "+(i+1)+ ":" + dailyTotals[i]);
            }
            double[] floorAverages = CalculateFloorAverages(revenue);
            Console.WriteLine("\nAverage revenue per floor:");
            for (int i = 0; i < floorAverages.Length; i++)
            {
                Console.WriteLine("Day " + (i + 1) + ":" + floorAverages[i]);
            }
            Console.Write("\nEnter floor number (1 to " + floorNumbers + ") to find best day: ");
            int floor = int.Parse(Console.ReadLine()) - 1;
            int bestDay = FindBestDayForFloor(revenue, floor);
            Console.WriteLine("Best day for floor" + (floor + 1) +" its Day "+ (bestDay + 1));

            Console.Write("\nEnter day number (1 to 7) to find top floor: ");
            int day = int.Parse(Console.ReadLine()) - 1;
            int bestFloor = FindFloorWithHighestRevenueOnDay(revenue, day);
            Console.WriteLine("Highest revenue on Day "+ (day + 1)+ " as from Floor " + (bestFloor + 1));

            Console.ReadKey();
        }
        static void PopulateRevenue(double[,] revenue)
        {
            for (int i = 0; i < revenue.GetLength(0); i++)
            {
                Console.WriteLine("Enter revenue for floor " + ( i + 1) + ":");
                for (int j = 0; j < revenue.GetLength(1); j++)
                {
                    Console.Write("Day " + (j+ 1) + ":");
                    revenue[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }
        static double[] CalculateDailyRevenueTotals (double[,] revenue)
        {
            double[] totalRevenue = new double[7];

            for (int j = 0;j < revenue.GetLength(1);j++)
            {
                double sum = 0;
                for (int i= 0; i < revenue.GetLength(0); i++)
                {
                    sum += revenue[i, j];
                }
                totalRevenue[j] = sum;
            }
            return totalRevenue;
        }
        static double[] CalculateFloorAverages(double[,] revenue)
        {
            double[] avg = new double[revenue.GetLength(0)];
            for (int i = 0; i < revenue.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < revenue.GetLength(1); j++)
                {
                    sum += revenue[i, j];
                }
                avg[i] = sum / revenue.GetLength(1);
            }
            return avg;
        }
        static int FindBestDayForFloor(double[,] revenue,int floor)
        {
            int bestDay = 0;
            double highest = revenue[floor,0];
            for (int j = 0; j < revenue.GetLength(1); j++)
            {
                if (highest < revenue[floor, j])
                {
                    highest = revenue[floor, j];
                    bestDay = j;
                }
            }
            return bestDay;
        }
        static int FindFloorWithHighestRevenueOnDay(double[,] revenue, int day)
        {
            int bestFloor = 0;
            double highest = revenue[0, day];
            for (int i = 1; i < revenue.GetLength(0); i++)
            {
                if (highest < revenue[i,day])
                {
                    highest = revenue[i,day];
                    bestFloor= i;
                }
            }
            return bestFloor+1 ;
        }
        
    }
}
