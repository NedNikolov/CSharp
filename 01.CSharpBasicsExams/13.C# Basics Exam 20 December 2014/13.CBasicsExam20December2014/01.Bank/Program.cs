using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankPrice = int.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());
            int normalDays = 30 - partyDays;
            int moneyNormal = normalDays*2;
            int moneyParty = partyDays*5;
            int savedMoney = moneyNormal - moneyParty;
            double moneyNeededd = (double)tankPrice/savedMoney;
            int moneyNeeded = (int)Math.Ceiling(moneyNeededd);
            int years = moneyNeeded/12;
            int months = moneyNeeded%12;


            if (partyDays > 8)
            {
                Console.WriteLine("never");

                
            }
            else
            {
                Console.WriteLine("{0} years, {1} months", years, months);
            }
        }
    }
}
