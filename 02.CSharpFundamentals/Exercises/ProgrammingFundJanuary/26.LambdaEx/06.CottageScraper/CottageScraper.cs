using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CottageScraper
{
    class CottageScraper
    {
        static void Main(string[] args)
        {
            var data = new List<KeyValuePair<string, int>>();
            string input = Console.ReadLine();
            while (input != "chop chop")
            {
                string[] inputTokens = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string woodType = inputTokens[0];
                int woodHeight = int.Parse(inputTokens[1]);

                data.Add(new KeyValuePair<string, int>(woodType, woodHeight));


                    input = Console.ReadLine();
            }

            string wantedType = Console.ReadLine();
            int minHeight = int.Parse(Console.ReadLine());

            var pricePerMeter = 
                Math.Round(data.Average(d => d.Value), 2);

            double usedLogsValue = data
                .Where(d => d.Key == wantedType && d.Value >= minHeight)
                .Sum(d => d.Value);

            double unusedLogsValue = data
                .Where(d => !(d.Key == wantedType && d.Value >= minHeight))
                .Sum(d => d.Value);

            usedLogsValue = Math.Round(usedLogsValue * pricePerMeter, 2);
            unusedLogsValue = Math.Round(unusedLogsValue * pricePerMeter * 0.25, 2);
            double totalPrice = Math.Round(usedLogsValue + unusedLogsValue, 2);

            Console.WriteLine("Price per meter: ${0:F2}", pricePerMeter);
            Console.WriteLine("Used logs price: ${0:F2}", usedLogsValue);
            Console.WriteLine("Unused logs price: ${0:F2}", unusedLogsValue);
            Console.WriteLine("CottageScraper subtotal: ${0:F2}", totalPrice);

        }
    }
}
