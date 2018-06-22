using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LargestNElements
{
    class LargestNElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var totalNumbers = int.Parse(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            var result = new List<int>();

            for (int i = 0; i < totalNumbers; i++)
            {
                result.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
