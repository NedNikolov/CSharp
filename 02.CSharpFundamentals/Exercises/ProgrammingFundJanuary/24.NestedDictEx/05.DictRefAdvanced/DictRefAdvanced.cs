using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DictRefAdvanced
{
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            var classMates = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputTokens = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];

                if (IsName(inputTokens[1]))
                {
                    string otherName = inputTokens[1];

                    if (classMates.ContainsKey(otherName))
                    {
                        List<int> otherNumbers = classMates[otherName];

                        if (!classMates.ContainsKey(name))
                        {
                            classMates[name] = new List<int>();
                        }
                        classMates[name].Clear();
                        classMates[name].AddRange(otherNumbers);

                    }
                    
                }
                else
                {
                    int[] numbers = inputTokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    if (!classMates.ContainsKey(name))
                    {
                        classMates[name] = new List<int>();
                    }
                    classMates[name].AddRange(numbers);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<int>> record in classMates)
            {
                string name = record.Key;
                List <int> numbers = record.Value;

                Console.WriteLine("{0} === {1}", name, string.Join(", ", numbers));
            }
        }

        static bool IsName(string input)
        {
            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
