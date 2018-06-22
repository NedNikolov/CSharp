using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Summertime
{
    class Summertime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char space = ' ';
            char dot = '.';
            char kliomba = '@';
            char star = '*';

            int leftSpace = n / 2;
            int midSpace = n - 1;



            Console.Write(new string(space, leftSpace));
            Console.Write(new string(star, n + 1));
            Console.Write(new string(space, leftSpace));
            Console.WriteLine();

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(space, leftSpace));
                Console.Write(new string(star, 1));
                Console.Write(new string(space, n - 1));
                Console.Write(new string(star, 1));
                Console.Write(new string(space, leftSpace));
                Console.WriteLine();
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(space, leftSpace));
                Console.Write(new string(star, 1));
                Console.Write(new string(space, midSpace));
                Console.Write(new string(star, 1));
                Console.Write(new string(space, leftSpace));
                Console.WriteLine();
                leftSpace--;
                midSpace += 2;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(space, leftSpace));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, midSpace));
                Console.Write(new string(star, 1));
                Console.Write(new string(space, leftSpace));
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(space, leftSpace));
                Console.Write(new string(star, 1));
                Console.Write(new string(kliomba, midSpace));
                Console.Write(new string(star, 1));
                Console.Write(new string(space, leftSpace));
                Console.WriteLine();
            }

            Console.WriteLine(new string(star, n * 2
                ));

        }
    }
}
