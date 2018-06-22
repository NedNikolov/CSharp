using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            
            string[] array = Console.ReadLine().Split(' ').ToArray();
            long altitude = long.Parse(array[0]);
            bool isCrashed = true;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (i % 2 == 1)
                {
                    if (array[i].Contains("up"))
                    {
                        altitude += long.Parse(array[i + 1]);
                    }
                    else if (array[i].Contains("down"))
                    {
                        altitude -= long.Parse(array[i + 1]);
                    }

                    if (altitude <= 0)
                    {
                        isCrashed = false;
                        Console.WriteLine("crashed");
                        break;
                    }
                }
            }
            if (isCrashed == true)
            {
                Console.WriteLine("got through safely. current altitude: {0}m", altitude);
            }


        }
    }
}
