using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.AnnieDrunk
{
    class Program
    {
        static void Main(string[] args)
        {

            long numberOfCabins = long.Parse(Console.ReadLine());

            long currentPosition = 0;
            long totalLenghtCovered = 0;
            string nextCommand = Console.ReadLine();
            while (nextCommand != "Found a free one!")
            {
                long stepsCount = long.Parse(nextCommand);
                long oldPosition = currentPosition;
                currentPosition = (currentPosition + stepsCount)%numberOfCabins;
                long difference = currentPosition - oldPosition;
                totalLenghtCovered = totalLenghtCovered + Math.Abs(difference);

                if (difference > 0)
                {
                    Console.WriteLine("Go {0} steps to the right, Ani.", difference);
                }
                else if (difference < 0)
                {
                    Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(difference));
                }
                else
                {
                    Console.WriteLine("Stay there, Ani.");
                }


                nextCommand = Console.ReadLine();
            }

            Console.WriteLine("Moved a total of {0} steps.", totalLenghtCovered);
        }
    }
}
