using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int lenght = int.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                var newLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < newLine.Count; j++)
                {
                    var currElement = newLine[j];
                    if (firstLine.Contains(currElement))
                    {
                        newLine.RemoveAll(x => x == currElement);
                        firstLine.RemoveAll(x => x == currElement);
                        j--;
                    }
                }
                firstLine.AddRange(newLine);
            }
            firstLine.Sort();
            Console.WriteLine(string.Join(" ", firstLine));
        }
    }
}
