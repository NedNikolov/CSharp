using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Budget
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());


            decimal outout = n * 0.03m;
            int rent = n - 150;
            int normalWeekends = 4 - h;
            int monthDays = 30 - ((h * 2)+(normalWeekends * 2));
            int normalWeekdays = monthDays - p;        
            int weekGOout = p*((int)outout + 10);
            int normalDays = normalWeekdays*10;
            int sum = rent - (weekGOout + normalDays + (normalWeekends*2*20));
            if (sum > 0)
            {
                Console.WriteLine("Yes, leftover {0}.", sum);
            }
            else if (sum < 0)
            {
                Console.WriteLine("No, not enough {0}.", Math.Abs(sum));
            }
            else
            {
                Console.WriteLine("Exact Budget.");
            }

        }
    }
}
