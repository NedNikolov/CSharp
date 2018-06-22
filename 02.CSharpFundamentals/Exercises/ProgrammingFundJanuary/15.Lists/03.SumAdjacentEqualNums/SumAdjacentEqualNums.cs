using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNums
{
    class SumAdjacentEqualNums
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
