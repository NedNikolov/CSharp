using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            Dictionary<char, byte> letterCollection = new Dictionary<char, byte>();
            string enteredString = Console.ReadLine();

            for (int i = 0; i < enteredString.Length; i++)
            {
                if (!letterCollection.ContainsKey(enteredString[i]))
                {
                    letterCollection.Add(enteredString[i], 0);
                }
                letterCollection[enteredString[i]]++;
            }

            foreach (KeyValuePair<char, byte> letter in letterCollection)
            {
                //var key = item.Key;
                //var value = item.Value;
                Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
            }

        }
    }
}
