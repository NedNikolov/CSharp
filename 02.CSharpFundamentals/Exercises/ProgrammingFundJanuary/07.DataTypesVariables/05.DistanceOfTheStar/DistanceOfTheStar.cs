using System;

namespace _05.DistanceOfTheStar
{
    class DistanceOfTheStar
    {
        static void Main(string[] args)
        {
            decimal lightYear = 9450000000000;
            decimal nearestStar = 4.22m * lightYear;
            decimal centerGalaxy = 26000 * lightYear;
            decimal milkyWay = 100000 * lightYear;
            decimal edgeUniverse = 46500000000 * lightYear;

            Console.WriteLine("{0:e2}",nearestStar);
            Console.WriteLine("{0:e2}", centerGalaxy);
            Console.WriteLine("{0:e2}", milkyWay);
            Console.WriteLine("{0:e2}", edgeUniverse);

        }
    }
}
