using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolii = int.Parse(Console.ReadLine());
            var zumbuli = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var kaktusi = int.Parse(Console.ReadLine());
            double pricePresent = int.Parse(Console.ReadLine());

            var flower1 = magnolii * 3.25;
            var flower2 = zumbuli * 4;
            var flower3 = rozi * 3.50;
            var flower4 = kaktusi * 8;

            var money = flower1 + flower2 + flower3 + flower4;
            var danuk = money * 0.05;
            var pechalba = money - danuk;

            var podaruk = Math.Abs(pechalba - pricePresent);
            if (pechalba > pricePresent)
            {
                Console.WriteLine("She is left with {0} leva.",Math.Floor(podaruk));
            }
            else if (pechalba < pricePresent)
            {
                Console.WriteLine("She will have to borrow {0} leva.",Math.Ceiling (podaruk));
            }
           
        }
    }
}
