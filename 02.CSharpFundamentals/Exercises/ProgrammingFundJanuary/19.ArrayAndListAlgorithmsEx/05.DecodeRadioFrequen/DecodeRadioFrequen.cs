using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFrequen
{
    class DecodeRadioFrequen
    {
        static void Main(string[] args)
        {
            string[] frequenciesInput = Console.ReadLine().Split(' ');
            List<char> endMessage = new List<char>();

            for (int i = 0; i < frequenciesInput.Length; i++)
            {
                string[] tokens = frequenciesInput[i].Split('.');
                int firstFreq = int.Parse(tokens[0]);
                int secondFreq = int.Parse(tokens[1]);

                char firstLEtter = (char)firstFreq;
                char secondLEtter = (char)secondFreq;

                if (firstFreq != 0)
                {
                    endMessage.Insert(i, firstLEtter);
                }

                if (secondLEtter != 0)
                {
                    endMessage.Insert(endMessage.Count - 1 - i, secondLEtter);
                }
            }
            endMessage.Reverse();
            Console.WriteLine(string.Join(string.Empty, endMessage));
        }
    }
}
