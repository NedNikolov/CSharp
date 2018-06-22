using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int containNum = int.Parse(Console.ReadLine());

            bool isContain = false;

            foreach (var number in numbers)
            {
                if (number == containNum)
                {
                    isContain = true;
                }
            }

            if (isContain == false)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}
