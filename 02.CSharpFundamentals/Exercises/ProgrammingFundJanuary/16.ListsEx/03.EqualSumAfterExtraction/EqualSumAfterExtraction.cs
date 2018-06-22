using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sumFirst = 0;
            int sumSecond = 0;

            for (int i = 0; i < firstLine.Count; i++)
            {
                for (int j = 0; j < secondLine.Count; j++)
                {
                    if (firstLine[i] == secondLine[j])
                    {
                        secondLine.RemoveAt(j);
                    }
                }
            }

            for (int f = 0; f < firstLine.Count; f++)
            {
                sumFirst += firstLine[f];
            }
            for (int s = 0; s < secondLine.Count; s++)
            {
                sumSecond += secondLine[s];
            }

            if (sumFirst == sumSecond)
            {
                Console.WriteLine("Yes. Sum: {0}", sumFirst);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sumFirst - sumSecond));
            }
        }
    }
}
