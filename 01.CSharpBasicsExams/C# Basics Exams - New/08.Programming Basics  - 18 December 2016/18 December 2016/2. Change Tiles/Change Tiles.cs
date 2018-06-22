using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneySpend = double.Parse(Console.ReadLine());
            double widthFloor = double.Parse(Console.ReadLine());
            double lengthFloor = double.Parse(Console.ReadLine());
            double sideTriangle = double.Parse(Console.ReadLine());
            double heightTriangle = double.Parse(Console.ReadLine());
            double priceTile = double.Parse(Console.ReadLine());
            double priceWorker = double.Parse(Console.ReadLine());   


            double areaFloor = widthFloor * lengthFloor;
            double areaTile = (sideTriangle * heightTriangle) / 2;
            double tileNeeded = (Math.Ceiling(areaFloor / areaTile)) + 5;
            double priceNeeded = (tileNeeded * priceTile) + priceWorker;
            double result = Math.Abs(priceNeeded - moneySpend);

            if (priceNeeded <= moneySpend)
            {
                Console.WriteLine("{0:F2} lv left.", result);
            }
            else
            {
                Console.WriteLine("You'll need {0:F2} lv more.",result);
            }
        }
    }
}

