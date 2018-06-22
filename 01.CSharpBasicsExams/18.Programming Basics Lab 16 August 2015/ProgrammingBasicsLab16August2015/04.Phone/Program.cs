using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Program
    {
        static void Main(string[] args)
        {
             
            long cabins = int.Parse(Console.ReadLine());

        long position = 0;
        long lCovered = 0;
        string command = Console.ReadLine();
        while (command != "Found a free one!")
        {
            long stepsTaken = int.Parse(command);
            long oldPosition = position;
            position = (oldPosition + stepsTaken) % cabins;
            long diff = position - oldPosition;
            if (diff > 0)
            {
                Console.WriteLine("Go {0} steps to the right, Ani.", diff);
            }
            else if (diff < 0)
            {
                Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(diff));
            }
            else
            {
                Console.WriteLine("Stay here Ani");
            }
            {

            }
            command = Console.ReadLine();
            lCovered = diff + position;
        }
        Console.WriteLine("Moved a total of {0} steps", lCovered);
    
        }
    }
}
