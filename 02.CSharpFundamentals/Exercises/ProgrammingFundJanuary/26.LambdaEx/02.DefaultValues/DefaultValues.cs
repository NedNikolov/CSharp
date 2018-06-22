using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefaultValues
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            string key = string.Empty;
            string value = string.Empty;
            Dictionary<string, string> keyValuePairs =
                new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                var splited = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                key = splited[0];
                value = splited[1];

                if (!keyValuePairs.ContainsKey(key))
                {
                    keyValuePairs[key] = String.Empty;
                }
                keyValuePairs[key] = value;

                input = Console.ReadLine();
            }

            string replace = Console.ReadLine();
            foreach (var pair in keyValuePairs
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length))
            {
                Console.WriteLine("{0} <-> {1}", pair.Key, pair.Value);
            }

            foreach (var pair in keyValuePairs
                .Where( x=> x.Value == "null"))
            {
                Console.WriteLine("{0} <-> {1}", pair.Key, replace);
            }
        }
    }
}
