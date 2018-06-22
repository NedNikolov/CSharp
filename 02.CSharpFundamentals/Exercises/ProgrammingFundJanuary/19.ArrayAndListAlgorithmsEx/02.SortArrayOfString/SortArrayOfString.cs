using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SortArrayOfString
{
    class SortArrayOfString
    {
        static void Main(string[] args)
        {
            var givenSequence = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < givenSequence.Length - 1; i++)
                {
                    var current = givenSequence[i];
                    var next = givenSequence[i + 1];
                    if (current.CompareTo(next) > 0)
                    {
                        givenSequence[i + 1] = current;
                        givenSequence[i] = next;

                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", givenSequence));
        }
    }
}
