using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var pool = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            double hour = double.Parse(Console.ReadLine());

            var allLiters = (pipe1 * hour) + (pipe2 * hour);

            if (allLiters <= pool)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%." ,
                    Math.Truncate(allLiters / pool * 100),
                    Math.Truncate(pipe1 * hour / allLiters * 100),
                    Math.Truncate(pipe2 * hour / allLiters * 100));
            }
            else
	        {
              Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hour , allLiters - pool);
        	}
        }
    }
}
