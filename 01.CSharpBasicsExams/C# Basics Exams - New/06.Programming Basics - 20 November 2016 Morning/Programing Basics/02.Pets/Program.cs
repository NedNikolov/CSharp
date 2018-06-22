using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double kg = double.Parse(Console.ReadLine());
            double dogKg = double.Parse(Console.ReadLine());
            double catKg = double.Parse(Console.ReadLine());
            double turtleG = double.Parse(Console.ReadLine());

            var dogFood = days * dogKg;
            var catFood = days * catKg;
            var turtleFood = days * turtleG * 0.001;
            var allFood = dogFood + catFood + turtleFood ;

            if (allFood <= kg)
            {
                
                Console.WriteLine("{0} kilos of food left.",
                    Math.Floor(kg - allFood));
            }
            else
            {

                Console.WriteLine("{0} more kilos of food are needed.",
                    Math.Ceiling(allFood - kg));
            }
        }
    }
}
