using System;
using System.Linq;

namespace _06.OddNumsOddPositions
{
    class OddNumsOddPositions
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1 && Math.Abs(array[i] % 2) == 1)
                {
                    Console.WriteLine($"Index {i} -> {array[i]}");
                }
            }
        }
    }
}
