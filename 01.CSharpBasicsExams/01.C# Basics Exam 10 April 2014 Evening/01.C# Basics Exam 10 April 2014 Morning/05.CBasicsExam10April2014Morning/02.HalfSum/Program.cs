using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HalfSum
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int firstCount = 0;
            int secondCount = 0;


            for (int i = 0; i < count; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                firstCount = firstCount + numbers;
            }
            for (int i = 0; i < count; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                secondCount = secondCount + numbers;
            }

            int result = Math.Abs(firstCount - secondCount);
            if (firstCount > secondCount)
            {
                Console.WriteLine("No, diff={0}", result);
            }
            else if (firstCount < secondCount)
            {
                Console.WriteLine("No, diff={0}", result);
            }
            else
            {
                Console.WriteLine("Yes, sum={0}", firstCount);
            }
        }
    }
}
