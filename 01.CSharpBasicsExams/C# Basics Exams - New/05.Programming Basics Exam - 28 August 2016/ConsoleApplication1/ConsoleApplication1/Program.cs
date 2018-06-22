using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());

            var dot = '.';
            var star = '*';

            //var dot1 = 1;
            var mid = a * 3;
            var starMid = a * 5;
            var firstFor = a - 1;
            var lastFor = a *2;
            

            for (int i = 0; i <1; i++)
            {
                Console.WriteLine(new string(dot, a) + new string(star, a * 3) + new string(dot, a));
            }

            for (int i = 0; i < firstFor; i++)
            {
                Console.WriteLine(new string(dot, a - 1) + new string(star, 1) + new string(dot, mid) + new string(star, 1) + new string(dot, a -1));
                a--;
                mid += 2;
            }
            Console.WriteLine(new string(star , starMid));
            a++;
            mid -= 2;

            for (int i = 0; i < lastFor; i++)
            {
                
                Console.WriteLine(new string(dot, a - 1) + new string(star, 1) + new string(dot, mid) + new string(star, 1) + new string(dot, a - 1));
                a++;
                mid -= 2;
            }

            Console.WriteLine(new string(dot, a - 1) + new string(star, 1) + new string(star, mid) + new string(star, 1) + new string(dot, a - 1));
        }
    }
}
