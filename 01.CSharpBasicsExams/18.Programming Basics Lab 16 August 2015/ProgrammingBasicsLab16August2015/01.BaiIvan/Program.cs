using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BaiIvan
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            decimal availableMoney = decimal.Parse(Console.ReadLine());
            decimal amontOfAlchohol = decimal.Parse(Console.ReadLine());
            decimal boughtAlcohol = 0;
            switch (dayOfWeek)
            {
                case 0:
                    boughtAlcohol = availableMoney/25m; break;
                case 1:
                    boughtAlcohol = availableMoney/21m; break;
                case 2:
                    boughtAlcohol = availableMoney/14m; break;
                case 3:
                    boughtAlcohol = availableMoney / 17m; break;
                case 4:
                    boughtAlcohol = availableMoney / 45m; break;
                case 5:
                    boughtAlcohol = availableMoney / 59m; break;
                case 6:
                    boughtAlcohol = availableMoney / 42m; break;
                default: break;
            }

            string status = "";

            if (boughtAlcohol > 1.5m)
            {
                status = "very drunk";
            }
            else if (boughtAlcohol >= 1.0m)
            {
                status = "drunk";
            }
            else
            {
                status = "sober";
            }

            if (amontOfAlchohol < boughtAlcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends", status, boughtAlcohol-amontOfAlchohol );
            }
            else if (amontOfAlchohol == boughtAlcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", status);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol", status, amontOfAlchohol - boughtAlcohol);
            }
        }
    }
}
