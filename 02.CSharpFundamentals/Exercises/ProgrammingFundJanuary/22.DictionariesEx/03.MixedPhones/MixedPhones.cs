using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> values = new SortedDictionary<string, long>();
            string[] input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Over")
            {
                string keyInput = input[0];
                string valueInput = input[1];
                long numValue;

                if (long.TryParse(valueInput, out numValue))
                {
                    values[keyInput] = numValue;
                }
                else
                {
                    values[valueInput] = int.Parse(keyInput);
                }

                input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

            }

            foreach (KeyValuePair<string, long> value in values)
            {
                Console.WriteLine("{0} -> {1}", value.Key, value.Value);
            }
        }
    }
}
