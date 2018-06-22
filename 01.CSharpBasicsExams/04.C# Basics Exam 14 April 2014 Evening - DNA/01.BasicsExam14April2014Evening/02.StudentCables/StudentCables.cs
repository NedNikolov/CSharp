using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentCables
{
    class StudentCables
    {
        static void Main()
        {
            int totalLength = 0;
            int joins = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cabLenght = int.Parse(Console.ReadLine());
                string cabMeasure = (Console.ReadLine());
                if (cabMeasure == "meters")
                {
                    cabLenght *= 100;
                }
                if (cabLenght >= 20)
                {
                    totalLength += cabLenght;
                    joins++;
                }
                totalLength = totalLength - 3 * (joins - 1);
                int cablesCount = totalLength / 504;
                int remainder = totalLength % 504;
                Console.WriteLine(cablesCount);
                Console.WriteLine(remainder);
            }
        }
    }
}
