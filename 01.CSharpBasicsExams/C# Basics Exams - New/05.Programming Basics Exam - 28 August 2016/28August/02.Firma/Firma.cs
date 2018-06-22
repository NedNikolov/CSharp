using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firma
{
    class Firma
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var whours = 8;

            var wdays = days - (days * 0.1);
            var workhours = wdays * whours;
            var workers1 = workers * (2 * days);
            var allhours = workhours + workers1;
            var lefthours = allhours - hours;
            //Console.WriteLine(Math.Floor(workhours));
            //Console.WriteLine(Math.Floor(allhours));
            if (allhours > hours)
            {
                Console.WriteLine("Yes!" + Math.Floor(lefthours) +" hours left.");
            }
            else
            {
                double result = Math.Abs(lefthours);
                Console.WriteLine("Not enough time!" + (Math.Ceiling(result)) + " hours needed.");
            }

            


        }
    }
}
