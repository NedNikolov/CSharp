using System;

namespace _01.HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            double resultMetres = (wingFlaps / 1000) * distance;
            Console.WriteLine($"{resultMetres:F2} m.");

            long hornetFlaps = wingFlaps / 100;
            long result = hornetFlaps + ((wingFlaps / endurance) * 5);
            Console.WriteLine($"{result} s.");

        }
    }
}
