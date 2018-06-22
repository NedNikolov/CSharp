using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> values = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                string keyInput = input[0];
                string valueInput = input[1];
                int numValue;

                if (int.TryParse(valueInput, out numValue))
                {
                    values[keyInput] = numValue;
                }
                else
                {
                    if (values.ContainsKey(valueInput))
                    {
                        values[keyInput] = values[valueInput];
                    }
                }

                input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, int> value in values)
            {
                Console.WriteLine("{0} === {1}", value.Key, value.Value);
            }
        }
    }
}
