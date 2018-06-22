using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var star = 0;
            var tire = (n * 2) + 1;
            var cherta1 = 1;
            var cherta = 1;
            int sec = n / 2;
            int ntwo = n;
            int calculating = ((n * 2) % 3) / 2;
            


            for (int i = 1; i <= n; i++)
            {
                tire -= 2;
                star++;
                Console.WriteLine(new string('*', star) + new string('\\', 1) + new string('-', tire) + new string('/', 1) + new string('*', star));
                
                
            }

            for (int i = 1; i <= ((n * 2) / 3) / 2; i++)
            {
                Console.WriteLine(new string('|', 1) + new string('*', sec) + new string('\\', 1) + new string('*', ntwo) + new string('/', 1) + new string('*', sec) + new string('|', 1));
                sec++;
                ntwo -= 2;
            }

            star = 0;
            tire = (n * 2) + 1;

            for (int i = 1; i <= n; i++)
            {
                tire -= 2;
                star++;
                Console.WriteLine(new string('-', star) + new string('\\', 1) + new string('*', tire) + new string('/', 1) + new string('-', star));


            }

        }
    }
}