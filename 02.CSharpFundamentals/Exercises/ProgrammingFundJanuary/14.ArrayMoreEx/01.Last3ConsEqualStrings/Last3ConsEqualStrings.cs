using System;
using System.Linq;

namespace _01.Last3ConsEqualStrings
{
    class Last3ConsEqualStrings
    {
        static void Main()
        {
            string[] word = Console.ReadLine().Split(' ').ToArray();
            string lastWord = "";

            for (int i = 0; i < word.Length - 2; i++)
            {
                if (word[i] == word[i + 1] && word[i + 1] == word[i + 2])
                {
                    lastWord = word[i];
                }
            }
            Console.WriteLine("{0} {0} {0}", lastWord);
        }
    }
}
