using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Check
{
    class Check
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());

            double rubles = (r/100) * 3.5d;
            double dollars = d*1.5d;
            double euros = e*1.95d;
            double twoInone = b/2.0;
            double normal = m;

            double mathMin = Math.Min(rubles, dollars);
            mathMin = Math.Min(mathMin, euros);
            mathMin = Math.Min(mathMin, twoInone);
            mathMin = Math.Min(mathMin, normal);

            Console.WriteLine("{0:0.00}", mathMin);

        }
    }
}
