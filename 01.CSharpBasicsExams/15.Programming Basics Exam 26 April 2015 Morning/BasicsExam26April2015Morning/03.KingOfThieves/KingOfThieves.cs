using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.KingOfThieves
{
    class KingOfThieves
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char type = char.Parse(Console.ReadLine());
            int sizeCount = 1;
            int typeCount = size / 2;
            for (int i = 1; i <= size; i++)
            {
                if (i <= (size/2))
                {
                    Console.WriteLine(new string('-', typeCount) + new string(type, sizeCount) + new string('-', typeCount));
                    typeCount -= 1;
                    sizeCount += 2;
                }
                else
                {
                    Console.WriteLine(new string('-', typeCount) + new string(type, sizeCount) + new string('-', typeCount));
                    typeCount += 1;
                    sizeCount -= 2;
                }
            }
        }
    }
}
