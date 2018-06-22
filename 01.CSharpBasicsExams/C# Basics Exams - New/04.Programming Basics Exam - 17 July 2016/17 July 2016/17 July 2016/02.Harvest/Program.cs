using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int wineArea = int.Parse(Console.ReadLine());
            double kgPerArea = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalKG = wineArea * kgPerArea * 0.4;
            double wineLitres = totalKG / 2.5;

            if (Math.Ceiling(wineLitres) > neededWine)
            {
                Console.WriteLine("Good harvest this year! Total wine : {0} liters.", Math.Floor(wineLitres));
                Console.WriteLine("{0} liters left -> {1} liters per person", Math.Ceiling(wineLitres - neededWine), Math.Ceiling(Math.Ceiling(wineLitres - neededWine) / workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(neededWine - wineLitres));
            }
        }
    }
}
