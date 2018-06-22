using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PowerPlants
{
    class PowerPlants
    {
        static void Main(string[] args)
        {
            var plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var ctr = -1;
            var days = 0;
            var sum = 0;
            var value = 0;

            for (int count = 0; ; count++)
            {
                ctr++;
                sum = 0;
                for (int index = 0; index < plants.Length; index++)
                {
                    plants[index] = days == index ? plants[index] : plants[index] - 1;
                    value = plants[index] <= 0 ? plants[index] = 0 : plants[index] = plants[index];
                    sum += value;
                }
                days++;
                days = days == plants.Length ? days = 0 : days += 0;
                if (days % plants.Length == 0)
                {
                    for (int index = 0; index < plants.Length; index++)
                    {
                        plants[index] = plants[index] > 0 ? plants[index] += 1 : plants[index] += 0;
                    }
                }
                if (sum == 0)
                {
                    break;
                }
            }
            var seasons = ctr / plants.Length == 1 ? "season" : "seasons";
            Console.WriteLine($"survived {ctr + 1} days ({ctr / plants.Length} {seasons})");
        }
    }
}
