using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int number = rnd.Next(0, words.Length);

                string temp = words[i];
                words[i] = words[number];
                words[number] = temp;
            }

            words.ToList().ForEach(Console.WriteLine);
        }
    }
}
