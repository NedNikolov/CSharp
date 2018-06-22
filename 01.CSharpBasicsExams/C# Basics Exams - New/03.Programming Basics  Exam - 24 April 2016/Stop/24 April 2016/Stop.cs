using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());

            var dot = '.';
            var tire = '_';
            string cherti = "//";
            string cherti2 = "\\\\";
            var mid = (a * 2) - 1;
            var dots = a + 1;
            var dots2 = a; 
            var tireta = (a * 2) + 1;


            Console.WriteLine(new string(dot, dots) + new string(tire, tireta) + new string(dot, dots));


            a--;
            for (int i = 0; i <= a; i++)
            {
               
                Console.WriteLine(new string(dot,dots2) + (cherti) + new string(tire,mid) + (cherti2) + new string(dot,dots2));
                dots2--;
                mid += 2;
            }

            mid -= 2;
            int middletire = (mid / 2) - 1;
            Console.WriteLine((cherti) + new string(tire, middletire) + "STOP!" + new string(tire, middletire) + (cherti2));
            mid += 2;
            for (int i = 0; i <= a; i++)
            {
                
                Console.WriteLine(new string(dot, dots2) + (cherti2) + new string(tire, mid) + (cherti) + new string(dot, dots2));
                mid -= 2;
                dots2++;
            }
        }
    }
}
