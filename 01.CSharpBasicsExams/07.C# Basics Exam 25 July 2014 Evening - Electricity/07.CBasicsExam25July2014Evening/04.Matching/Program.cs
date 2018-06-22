using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Matching
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            char dot = '.';
            char star = '*';
            int leftdot = n - 1;
            int middledot = 1;

            Console.Write(new string(dot, leftdot));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, leftdot));
            Console.WriteLine();

            for (int i = 0; i < n-1; i++)
            {
                leftdot--;

                Console.Write(new string(dot, leftdot));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, middledot));
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, leftdot));
                Console.WriteLine();
                middledot += 2;
            }

            Console.WriteLine(new string(star, n+ (n-1)));

            for (int i = 0; i < n/4; i++)
            {
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, n+(n-3)));
                Console.Write(new string(star, 1));
                Console.WriteLine();
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, n /2));
                Console.Write(new string(star, (n+ (n-1))-(2+n) ));
                Console.Write(new string(dot, n / 2));
                Console.Write(new string(star, 1));
                Console.WriteLine();
            }


            for (int i = 0; i < n / 4; i++)
            {
                Console.Write(new string(star, 1));
                Console.Write(new string(dot, n + (n-3)));
                Console.Write(new string(star, 1));
                Console.WriteLine();
            }

            Console.WriteLine(new string(star, n + (n - 1)));
        }
    }
}
