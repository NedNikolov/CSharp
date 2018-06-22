using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace _03.DreamItem
{
    class DreamItem
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            string [] input = Console.ReadLine().Split('\\');
            string month = input[0];
            decimal moneyPerHour = decimal.Parse(input[1]);
            decimal hoursPerDay = decimal.Parse(input[2]);
            decimal itemPrice = decimal.Parse(input[3]);
            int daysPerMonth = 31;

            switch (month)
            {
                case "Feb":
                    daysPerMonth = 18; break;
                case "Apr":
                case "Jun":
                case "Sept":
                case "Nov":
                    daysPerMonth = 20; break;
                default:
                    daysPerMonth = 21; break;
            }

            decimal hoursPerMonth = hoursPerDay*daysPerMonth;
            decimal moneyPerMonth = hoursPerMonth*moneyPerHour;

            if (moneyPerMonth > 700)
            {
                moneyPerMonth = moneyPerMonth + (moneyPerMonth * 0.1m);
            }

            decimal moneyLeft = moneyPerMonth - itemPrice;

            if (moneyLeft >= 0)
            {
                Console.WriteLine("Money left = {0:0.00} leva.", moneyLeft );
            }
            else
            {
                Console.WriteLine("Not enough money. {0:0.00} leva needed.", Math.Abs( moneyLeft) );
            }
        }
    }
}
