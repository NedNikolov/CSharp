using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            var batteries = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            var usagePerHour = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            var stressTime = int.Parse(Console.ReadLine());

            StatusForEachBatteri(batteries, usagePerHour, stressTime);


        }

        private static void StatusForEachBatteri(double[] batteries, double[] usagePerHour, int stressTime)
        {
            var counter = 1;
            for (int index = 0; index < batteries.Length; index++)
            {
                var balance = batteries[index] - (usagePerHour[index] * stressTime);
                var percent = (balance / batteries[index]) * 100;
                if (balance > 0)
                {
                    Console.WriteLine("Battery {0}: {1:F2} mAh ({2:F2})%",counter, balance, percent);
                }
                else
                {
                    var lasted = Math.Ceiling(batteries[index] / usagePerHour[index]);
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", counter, lasted);
                }
                counter++;

            }
        }
    }
}
