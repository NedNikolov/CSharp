using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Traveller_Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalMonths = 12;
            string leap = Console.ReadLine();
            int c = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            totalMonths = totalMonths - (c + f);
            int contract = c * 12;
            int family = f * 4;
            double normal = (((12 - (c + f)) * 12) * 3/5.0);
            double noLeap = contract + family + normal;
            double procent = noLeap * 0.05;
            double ifLeap = noLeap + procent;
            int ifLeape = (int)ifLeap;
            int noLeape = (int)noLeap;

            if (leap == "leap")
            {
                Console.WriteLine(ifLeape);
            }
            else
            {
                Console.WriteLine(noLeape);
            }
        }
    }
}
