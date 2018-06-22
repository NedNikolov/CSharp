using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> values = new Dictionary<string, int>();
            var enteredData = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var product = string.Empty;
            var quantity = 0;

            while (enteredData[0] != "exam")
            {
                if (enteredData[0] == "stock")
                {
                    product = enteredData[1];
                    quantity = Convert.ToInt32(enteredData[2]);
                    StockProducts(values, product, quantity);
                }
                else if (enteredData[0] == "buy")
                {
                    product = enteredData[1];
                    quantity = Convert.ToInt32(enteredData[2]);
                    BuyProducts(values, product, quantity);
                }

                enteredData = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, int> value in values)
            {
                if (value.Value > 0)
                {
                    Console.WriteLine("{0} -> {1}", value.Key, value.Value);
                }
            }
        }

        private static void StockProducts(Dictionary<string, Int32> value, string product, int quantity)
        {
            if (!value.ContainsKey(product))
            {
                value[product] = 0;
            }
            value[product] += quantity;
        }

        private static void BuyProducts(Dictionary<string, int> value, string product, int quantity)
        {
            if (!value.ContainsKey(product))
            {
                Console.WriteLine($"{product} doesn't exist");
            }
            else if (value.ContainsKey(product) && value[product] > 0)
            {
                value[product] -= quantity;
            }
            else if (value.ContainsKey(product) && value[product] <= 0)
            {
                Console.WriteLine($"{product} out of stock");
            }
        }
    }
}
