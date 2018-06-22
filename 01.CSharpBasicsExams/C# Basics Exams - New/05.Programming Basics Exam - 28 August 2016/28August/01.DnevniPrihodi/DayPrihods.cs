using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DnevniPrihodi
{
    class DayPrihods
    {
        static void Main(string[] args)
        {
            var wd = int.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());
            var dolarLeva = double.Parse(Console.ReadLine());

            var month = wd * money;
            var yearMoney = (month * 12) + (month * 2.5);
            var bill = yearMoney * 0.25;
            var clearMoney = yearMoney - bill;
            var leva = clearMoney * dolarLeva;
            var result = leva / 365;

            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
