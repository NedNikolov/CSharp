using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            //double skumriqKg = double.Parse(Console.ReadLine());
            //double skumriqPrice = double.Parse(Console.ReadLine());
            //double palamudKg = double.Parse(Console.ReadLine());
            //double safridKg = double.Parse(Console.ReadLine());
            //double midikg = double.Parse(Console.ReadLine());

            //var palamudPrice = (skumriqKg + skumriqKg * 0.60 ) * palamudKg;
            //var safridPrice = (skumriqPrice + skumriqPrice * 0.80) * safridKg;
            //var midiPrice = midikg * 7.50;
            //var price = palamudPrice + safridPrice + midiPrice;
            //Console.WriteLine("{0:f2}",price);
            var n = 4;
            var sumTovar = 0;
            var microbus = 0;
            var truck = 0;
            var train = 0;


            for (int i = 1; i <= n; i++)
            {
                var tovar = int.Parse(Console.ReadLine());
                sumTovar = sumTovar + tovar;

                if (tovar <= 3)
                {
                    microbus += tovar;
                }
                else if (tovar >= 4 && tovar <= 11)
                {
                    truck += tovar;
                }
                else if (tovar > 11)
                {
                    train += tovar;
                }

            }
            var allTovar = ((microbus * 200) + (truck * 175) + (train * 120)) / sumTovar;
            var microbuss = (microbus / sumTovar) * 100;
            var truckk = (truck / sumTovar) * 100;
            var trainn = (train / sumTovar) * 100;
            Console.WriteLine(allTovar);
            Console.WriteLine("{0:f2}%", microbuss);
            Console.WriteLine("{0:f2}%", truckk);
            Console.WriteLine("{0:f2}%", trainn);
        }
    }
}
