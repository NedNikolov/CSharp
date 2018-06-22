using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesReverse
{
    class RemoveNegativesReverse
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> newNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    newNumbers.Add(numbers[i]);
                }
            }
            newNumbers.Reverse();
            if (newNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", newNumbers));
            }
            
        }
    }
}
