using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string wishTime = Console.ReadLine();
            string format = "mm:ss";
            long result = 0;
            long counter = 0;
            decimal oldPosition = 0;
            while (wishTime != "Quit")
            {
                DateTime wish = DateTime.ParseExact(wishTime, format, CultureInfo.InvariantCulture);
                result = wish.Minute * 60 + wish.Second;               
                oldPosition = oldPosition + result;
                counter++;               
                wishTime = Console.ReadLine();
            }
            decimal lookingStar = Math.Ceiling(oldPosition/counter);

            if (lookingStar < 720)
            {
                Console.WriteLine("Gold Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", counter, lookingStar);
            }
            else if ((lookingStar >= 720) || (lookingStar <= 1440))
            {
                Console.WriteLine("Silver Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", counter, lookingStar);               
            }
            else 
            {
                Console.WriteLine("Bronze Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", counter, lookingStar);
            }
        }

        
    }
}
