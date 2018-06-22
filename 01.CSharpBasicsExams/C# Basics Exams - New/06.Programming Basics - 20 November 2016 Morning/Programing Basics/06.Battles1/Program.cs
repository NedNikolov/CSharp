using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstGay = int.Parse(Console.ReadLine());
            int secondGay = int.Parse(Console.ReadLine());
            int tardBattle = int.Parse(Console.ReadLine());
            int tardCounter = 0;

            for (int i = 1; i <= firstGay; i++)
            {
                for (int j = 1; j <= secondGay; j++)
                {
                    Console.Write("({0} <-> {1}) ", i, j);
                    tardCounter++;
                    if (tardBattle == tardCounter)
                    {
                        return;
                    }
                }
            }
        }
    }
}
