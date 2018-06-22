using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            float priceV = float.Parse(Console.ReadLine());
            float priceF = float.Parse(Console.ReadLine());
            int kgV = int.Parse(Console.ReadLine());
            int kgF = int.Parse(Console.ReadLine());

            var vegetablePrice = priceV * kgV;
            var fruitPrice = priceF * kgF;
            Console.WriteLine((fruitPrice + vegetablePrice) / 1.94);
        }
    }
}
