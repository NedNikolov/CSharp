using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.Electricity
{
    class Electricity
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            DateTime time  = DateTime.Parse(Console.ReadLine());

            double lamp = 100.53d;
            double computer = 125.90d;
            double firstValue = (lamp*2) + (computer*2);
            double secondValue = (lamp*7) + (computer*6);
            double thirdValue = lamp + (computer*8);
            double allFlats = floors*flats;


            double finalResult = 0;
            if (time.Hour >= 14 && time.Hour <= 18)
            {
                finalResult = Math.Floor(allFlats*firstValue);
            }
            else if (time.Hour >= 19 && time.Hour <= 23)
            {
                finalResult = Math.Floor(allFlats * secondValue);
            }
            else if (time.Hour >= 0 && time.Hour <= 8)
            {
                finalResult = Math.Floor(allFlats * thirdValue);
            }
            else
            {

            }
            Console.WriteLine("{0} Watts", finalResult);
        }
    }
}
