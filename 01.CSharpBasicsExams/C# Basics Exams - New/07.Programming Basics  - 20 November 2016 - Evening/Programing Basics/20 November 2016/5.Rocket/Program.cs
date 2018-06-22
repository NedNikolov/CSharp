using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int .Parse(Console.ReadLine());
            var dot = (n + (n / 2)) - 1;
            var space = 0;
            int calculating = (n + (n / 2)) - 1;
            var dot1 = n / 2;
            var star1 = (n * 2) -2 ;

            //Top
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(new string('.', dot) + new string('/', 1) +
                    new string(' ', space) + new string('\\', 1) + new string('.', dot));
                space += 2;
                dot--;
                
            }
            //First Middle
            Console.WriteLine(new string('.', n / 2) + new string('*', n * 2) + new string('.', n / 2));

            //Middle
            for (int i = 1; i <= n * 2; i++)
            {
                Console.WriteLine(new string('.', n / 2) + new string('|', 1) + new string('\\', (n * 2) - 2)+ 
                    new string('|', 1) + new string('.', n / 2));
            }

            //Bottom
            for (int i = 1; i <= n / 2; i++)
            {
                
                Console.WriteLine(new string('.',dot1) + new string('/',1) + new string('*',star1) +
                    new string('\\', 1) + new string('.', dot1));
                star1 += 2;
                dot1--;
            }
            
        }
    }
}
