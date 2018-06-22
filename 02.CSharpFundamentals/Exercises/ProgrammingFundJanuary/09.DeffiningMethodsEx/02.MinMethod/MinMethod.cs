using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinMethod
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int minMin = GetMin(a, b, c);
            Console.WriteLine(minMin);
        }

        static int GetMin(int a, int b, int c)
        {
            int one = Math.Min(a, b);
            int two = Math.Min(b, c);
            if (one < two)
            {
                return one;
            }
            return two;

        }
    }
}
