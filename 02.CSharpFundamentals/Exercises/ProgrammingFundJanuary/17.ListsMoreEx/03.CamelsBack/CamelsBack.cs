using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CamelsBack
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            var buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int camelBack = int.Parse(Console.ReadLine());

            int result = (buildings.Count - camelBack) / 2;

            for (int i = 0; i < result; i++)
            {
                buildings.RemoveAt(0);
                buildings.RemoveAt(buildings.Count - 1);
            }

            if (result == 0)
            {
                Console.Write("already stable: ");
                Console.WriteLine(string.Join(" ", buildings));
            }
            else
            {
                Console.WriteLine("{0} rounds", result);
                Console.Write("remaining: ");
                Console.WriteLine(string.Join(" ", buildings));
            }
            
        }
    }
}
