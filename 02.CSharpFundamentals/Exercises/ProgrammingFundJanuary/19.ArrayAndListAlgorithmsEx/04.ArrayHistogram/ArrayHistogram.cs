using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            List<int> counts = new List<int>();

            string[] inputStrings = Console.ReadLine().Split(' ');

            for (int i = 0; i < inputStrings.Length; i++)
            {
                if (!words.Contains(inputStrings[i]))
                {
                    words.Add(inputStrings[i]);
                    counts.Add(1);
                }
                else
                {
                    int index = words.IndexOf(inputStrings[i]);
                    counts[index]++;
                }
            }

            for (int firstUnsorted = 0; firstUnsorted < counts.Count - 1; firstUnsorted++)
            {
                var i = firstUnsorted + 1;
                while (i > 0)
                {
                    if (counts[i - 1] < counts[i])
                    {
                        int tempcount = counts[i];
                        counts[i] = counts[i - 1];
                        counts[i - 1] = tempcount;

                        string tempWord = words[i];
                        words[i] = words[i - 1];
                        words[i - 1] = tempWord;
                    }
                    i--;
                }

            }

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine("{0} -> {1} times ({2:F2}%)", words[i], counts[i], ((double)counts[i] / (double)inputStrings.Length) * 100);
            }
        }
    }
}
