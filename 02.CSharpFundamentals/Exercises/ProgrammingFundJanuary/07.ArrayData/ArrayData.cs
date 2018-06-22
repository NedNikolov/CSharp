using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ArrayData
{
    class ArrayData
    {
        static void Main(string[] args)
        {
            var givenArray = Console.ReadLine().Split(' ')
                .Select(x => Convert.ToInt64(x)).ToList();

            var average = givenArray.Average();

            var currentArray = givenArray.Where(x => x >= average).ToList();

            var command = Console.ReadLine();
            if (command == "Min")
            {
                Console.WriteLine(currentArray.Min());
            }
            else if (command == "Max")
            {
                Console.WriteLine(currentArray.Max());
            }
            else
            {
                Console.WriteLine(string.Join(" ", currentArray.OrderBy(x => x)));
            }
        }
    }
}
