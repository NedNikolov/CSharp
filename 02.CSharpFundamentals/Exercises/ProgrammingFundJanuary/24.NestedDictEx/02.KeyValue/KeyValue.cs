using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KeyValue
{
    class KeyValue
    {
        static void Main(string[] args)
        {
            var collectionFromKeysValues = new Dictionary<string, List<string>>();
            var key = Console.ReadLine();
            var value = Console.ReadLine();
            var lines = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] currentLine = Console.ReadLine().Split(new[] { ' ', ';' });
                string givenKey = currentLine[0];
                var givenValues = currentLine.Skip(2);

                if (givenKey.Contains(key))
                {
                    if (!collectionFromKeysValues.ContainsKey(givenKey))
                    {
                        collectionFromKeysValues[givenKey] = new List<string>();
                    }
                    foreach (var givValue in givenValues)
                    {
                        if (value.Contains(givValue) || givValue.Contains(value))
                        {
                            collectionFromKeysValues[givenKey].Add(givValue);
                        }
                    }
                }
            }

            foreach (var result in collectionFromKeysValues)
            {
                Console.WriteLine("{0}:", result.Key);
                foreach (var element in result.Value)
                {
                    Console.WriteLine("-{0}", element);
                }
            }
        }
    }
}
