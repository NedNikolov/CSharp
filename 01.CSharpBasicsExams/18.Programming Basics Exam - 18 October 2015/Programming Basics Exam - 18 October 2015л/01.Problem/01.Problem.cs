using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char firstSymbol = Console.ReadLine()[0];
            char secondSymbol = Console.ReadLine()[0];

            int midDots = n;
            int lenthCycle = n * 4 + 1;





            int secNum = n + (n - 1);
            int dificut = secNum - 2;
            int firstDot = n - 1;
            int midDot = 1;

            Console.Write(new string(firstSymbol, n));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, secNum));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, n));
            Console.WriteLine();

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(firstSymbol, firstDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, midDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, dificut));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, midDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, firstDot));
                Console.WriteLine();
                firstDot--;
                midDot += 2;
                dificut -= 2;
            }
            Console.Write(new string(firstSymbol, firstDot));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, midDot));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, midDot));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, firstDot));
            Console.WriteLine();

            firstDot++;
            midDot -= 2;
            dificut += 2;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(firstSymbol, firstDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, midDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, dificut));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, midDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, firstDot));
                Console.WriteLine();
                firstDot++;
                midDot -= 2;
                dificut += 2;
            }

            Console.Write(new string(firstSymbol, n));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, secNum));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, n));
            Console.WriteLine();

            firstDot--;
            midDot += 2;
            dificut -= 2;

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(firstSymbol, firstDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, midDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, dificut));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, midDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, firstDot));
                Console.WriteLine();
                firstDot--;
                midDot += 2;
                dificut -= 2;
            }
            Console.Write(new string(firstSymbol, firstDot));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, secNum));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, secNum));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, firstDot));
            Console.WriteLine();

            firstDot++;
            midDot -= 2;
            dificut += 2;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(firstSymbol, firstDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, midDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, dificut));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, midDot));
                Console.Write(new string(secondSymbol, 1));
                Console.Write(new string(firstSymbol, firstDot));
                Console.WriteLine();
                firstDot++;
                midDot -= 2;
                dificut += 2;
            }

            Console.Write(new string(firstSymbol, n));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, secNum));
            Console.Write(new string(secondSymbol, 1));
            Console.Write(new string(firstSymbol, n));
            Console.WriteLine();

        }
    }
}