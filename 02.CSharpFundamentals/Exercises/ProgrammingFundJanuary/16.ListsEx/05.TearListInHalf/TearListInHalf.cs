using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TearListInHalf
{
    class TearListInHalf
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split();
            var workCollection = new List<string>();
            var firstSymbol = string.Empty;
            var lastSymbol = string.Empty;
            var counter = sequence.Length / 2;
            for (int index = 0; index < counter; index++)
            {
                firstSymbol = Convert.ToString(sequence[counter + index][0]);
                lastSymbol = Convert.ToString(sequence[counter + index][1]);
                workCollection.Add(firstSymbol);
                workCollection.Add(sequence[index]);
                workCollection.Add(lastSymbol);
            }
            Console.WriteLine(string.Join(" ", workCollection));
        }
    }
}
