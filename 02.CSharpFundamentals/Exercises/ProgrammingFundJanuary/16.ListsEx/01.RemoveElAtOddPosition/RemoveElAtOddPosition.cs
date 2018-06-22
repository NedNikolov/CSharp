using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveElAtOddPosition
{
    class RemoveElAtOddPosition
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            for (int i = 1; i < input.Count; i+=2)
            {
                Console.Write(input[i]);
            }
        }
    }
}
