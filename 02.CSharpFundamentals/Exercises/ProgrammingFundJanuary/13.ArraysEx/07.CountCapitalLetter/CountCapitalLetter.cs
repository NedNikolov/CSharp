using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountCapitalLetter
{
    class CountCapitalLetter
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == 1)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
