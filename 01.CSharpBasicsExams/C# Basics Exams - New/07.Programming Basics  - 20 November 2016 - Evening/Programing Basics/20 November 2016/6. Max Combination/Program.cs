using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxCombination = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 1; i <= start; i++)
            {
                for (int j = 1; j <= end; j++)
                {
                    Console.Write("<{0}-{1}>", i, j);
                    counter++;
                    if (maxCombination == counter)
                    {
                        return;
                    }
                }
            }
        }
    }
}
