using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = (Console.ReadLine());

            var price = 0.0;
            string test = "Somewhere in Bulgaria";
            string place = "Camp - ";

            if (budget <= 100 && season == "summer" )
            {
                price = budget * 0.3;
                test = "Somewhere in Bulgaria"; ;
                place = "Camp - ";
            }
            else if (budget <= 100 && season == "winter")
            {
                price = budget * 0.7;
                test = "Somewhere in Bulgaria"; ;
                place = "Hotel - ";
            }
            else if (budget <= 1000 && season =="summer")
            {
                price = budget * 0.4;
                test = "Somewhere in Balkans";
                place = "Camp - ";
            }
            else if (budget <= 1000 && season == "winter")
	        {
                price = budget * 0.8;
                test = "Somewhere in Balkans";
                place = "Hotel - ";
	        }
            else if (budget >= 1000 && (season == "summer" || season == "winter"))
            {
                price = budget * 0.9;
                test = "Somewhere in Europe";
                place = "Hotel - ";
            }
            Console.WriteLine(test);
            Console.WriteLine(place + "{0:F2}", price);
            
        }
    }
}
