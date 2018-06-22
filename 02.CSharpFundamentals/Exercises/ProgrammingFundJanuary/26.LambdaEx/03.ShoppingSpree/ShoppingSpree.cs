using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> mealProductsCollection = new Dictionary<string, double>();
            double price = 0;
            string product = string.Empty;

            var moneyToSpend = Convert.ToDouble(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "end")
            {
                var splitedProducts = input.Split(' ');
                product = splitedProducts[0];
                price = Convert.ToDouble(splitedProducts[1]);

                if (mealProductsCollection.ContainsKey(product))
                {
                    var oldPrice = mealProductsCollection[product];
                    if (oldPrice > price)
                    {
                        mealProductsCollection[product] = price;
                    }
                    else mealProductsCollection[product] = oldPrice;
                }
                else
                {
                    mealProductsCollection[product] = price;
                }

                input = Console.ReadLine();
            }

            if (mealProductsCollection.Values.Sum() <= moneyToSpend)
            {
                foreach (var pair in mealProductsCollection
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key.Length))
                {
                    Console.WriteLine("{0} costs {1:F2}", pair.Key, pair.Value);
                }
            }
            else
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
        }
    }
}
