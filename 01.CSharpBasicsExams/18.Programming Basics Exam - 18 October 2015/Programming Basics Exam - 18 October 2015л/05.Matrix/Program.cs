using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -4;
            int b  = 11;
            int c = -8;
                            //(-4 * 11 * -8) + (8 * 11 * 10) + (1 * -11 * -9) - (1 * 11 * 10) - (-4 * 11 * -9) - (8 * -11 * -8)
            Console.WriteLine(352+880+99-110-396-704);
            Console.WriteLine((-4 * 11 * -8) + (8 * 11 * 10) + (1 * -11 * -9) - (1 * 11 * 10) - (-4 * 11 * -9) - (8 * -11 * -8));
        }
    }
}
