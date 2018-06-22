using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            var currentSequens = Console.ReadLine().Split();
            var temporaryElement = string.Empty;
            var loopIterations = currentSequens.Length / 2;

            for (int i = 1; i < loopIterations; i++)
            {
                temporaryElement = currentSequens[i];
                currentSequens[i] = currentSequens[currentSequens.Length - i - 1];
                currentSequens[currentSequens.Length - i - 1] = temporaryElement;
            }
            Console.WriteLine(string.Join(" ", currentSequens));
        }
    }
}
