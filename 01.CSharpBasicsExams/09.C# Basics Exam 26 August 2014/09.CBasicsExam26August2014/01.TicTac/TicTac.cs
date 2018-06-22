using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TicTac
{
    class TicTac
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            int index = y*3 + x + 1;
            int finalValue = value + index - 1;
            long powered = (long) Math.Pow(finalValue, index);
            Console.WriteLine(powered);
        }
    }
}
