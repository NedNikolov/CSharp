using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            var shellAndSize = new Dictionary<string, HashSet<long>>();
            var input = Console.ReadLine();
            while (input != "Aggregate")
            {
                var citySize = input.Split(' ').ToArray();
                string city = citySize[0];
                long size = long.Parse(citySize[1]);

                if (!shellAndSize.ContainsKey(city))
                {
                    shellAndSize[city] = new HashSet<long>();
                }
                shellAndSize[city].Add(size);

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, HashSet<long>> pair in shellAndSize)
            {
                var sum = pair.Value.Sum();
                var result = (sum) - (sum / pair.Value.Count);
                Console.WriteLine("{0} -> {1} ({2})", pair.Key, string.Join(", ",pair.Value), result);
            }
        }
    }
}
