using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            var group = int.Parse(Console.ReadLine());

            var ticketPrice = category == "VIP" ? 499.99 : 249.99;
           
            var moneyLeft = budget;


            if (group < 5)
            {
                moneyLeft = moneyLeft - (budget * 0.75);
            }
            else if (group >= 5 && group < 10)
            {
                moneyLeft = moneyLeft - (budget * 0.60);
            }
            else if (group >= 10 && group < 25)
            {
                moneyLeft = moneyLeft - (budget * 0.50);
            }
            else if (group >= 25 && group < 50)
            {
                moneyLeft = moneyLeft - (budget * 0.40);
            }
            else 
            {
                moneyLeft = moneyLeft - (budget * 0.25);
            }

            var allTicketsPrice = group * ticketPrice;
            if (allTicketsPrice > moneyLeft)
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", allTicketsPrice - moneyLeft);
            }
            else
            {
                moneyLeft -= allTicketsPrice;
                Console.WriteLine("Yes! You have {0:F2} leva left.", moneyLeft);
            }
        }
    }
}
