using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SmallestElementArray
{
    class SmallestElementArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxNum = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currNum = numbers[i];
                if (currNum < maxNum)
                {
                    maxNum = currNum;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
