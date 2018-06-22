using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            char tire = '-';
            char star = '*';

            int daljina = a * 3;
            int daljina2 = a - 1;
            int tirelengh = 1;
            int lasttire = a - 2;


            Console.WriteLine(new string(tire, daljina) + new string(star, 2) + new string(tire, daljina2) + new string(tire, daljina2));

            for (int i = 0; i < a - 1; i++)
            {
                Console.WriteLine(new string(tire, daljina) + new string(star, 1) + new string(tire, tirelengh) + new string(star, 1) + new string(tire, lasttire) + new string(tire, daljina2));
                tirelengh++;
                lasttire--;
            }

            int secfor = a / 2;

            for (int i = 0; i < secfor; i++)
            {
                Console.WriteLine(new string(star, daljina) + new string(star, 1) + new string(tire, a - 1) + new string(star, 1) + new string(tire, a - 1));
            }

            int lastformula = (a / 2) - 1;
            daljina2 = a - 1;
            int daljina3 = a - 1;

            for (int i = 0; i < lastformula; i++)
            {
                Console.WriteLine(new string(tire, daljina) + new string(star, 1) + new string(tire, daljina2) + new string(star, 1) + new string(tire, daljina3));
                daljina--;
                daljina2 += 2;
                daljina3--;
            }

            Console.WriteLine(new string(tire, daljina) + new string(star, 1) + new string(star, daljina2) + new string(star, 1) + new string(tire, daljina3));
        }
    }
}
