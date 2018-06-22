using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var track = Console.ReadLine();

            var priceTrail = (juniors * 5.50) + (seniors * 7);
            var priceCross = (juniors * 8) + (seniors * 9.50);
            var priceDown = (juniors * 12.25) + (seniors * 13.75);
            var priceRoad = (juniors * 20) + (seniors * 21.50);
            var racers = juniors + seniors;

            if (track == "trail")
            {
               var priceTrail1= priceTrail - (priceTrail * 0.05);
               Console.WriteLine("{0:F2}", priceTrail1);
            }
            else if (track == "cross-country")
            {
                if (racers >= 50)
                {
                    var priceCross1 = priceCross - (priceCross * 0.05);
                    var priceCross2 = priceCross1 - (priceCross1 * 0.25) ;
                    Console.WriteLine("{0:F2}",priceCross2);
                }
                else
                {
                    var priceCross1 = priceCross - (priceCross * 0.05);
                    Console.WriteLine("{0:F2}", priceCross1);
                }
            }
            else if (track == "downhill")
            {
                var priceDown1 = priceDown - (priceDown * 0.05);
                Console.WriteLine("{0:F2}",priceDown1);
            }
            else if (track == "road")
            {
                var priceRoad1 = priceRoad - (priceRoad * 0.05);
                Console.WriteLine("{0:F2}",priceRoad1);
            }
        }
    }
}
