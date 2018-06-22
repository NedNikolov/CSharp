using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IncreasingSeqElements
{
    class IncreasingSeqElements
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            bool isBigger = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    isBigger = false;
                    break;
                }
            }
            if (isBigger == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
