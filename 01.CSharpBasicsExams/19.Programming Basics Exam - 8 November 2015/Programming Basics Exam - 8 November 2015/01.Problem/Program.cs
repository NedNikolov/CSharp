using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            long buildersNeed = long.Parse(Console.ReadLine());
            long recepcionistsNeed = long.Parse(Console.ReadLine());
            long chambermaidsNeed = long.Parse(Console.ReadLine());
            long techniciansNeed = long.Parse(Console.ReadLine());
            long othersNeed = long.Parse(Console.ReadLine());
            decimal nickiSalary = decimal.Parse(Console.ReadLine());
            decimal currentlyRateMoment = decimal.Parse(Console.ReadLine());
            decimal yourSalary = decimal.Parse(Console.ReadLine());
            decimal theBudget = decimal.Parse(Console.ReadLine());

            decimal neededMoney = (buildersNeed*1500.04m)+(recepcionistsNeed*2102.10m)+(chambermaidsNeed*1465.46m)+
                (techniciansNeed*2053.33m)+(othersNeed*3010.98m);
            decimal salaryNickiLeva = nickiSalary*currentlyRateMoment;
            decimal totalAmountMoney = neededMoney + salaryNickiLeva + yourSalary;
            decimal finalCount = Math.Abs(theBudget - totalAmountMoney);
            Console.WriteLine("The amount is: {0:F2} lv.", totalAmountMoney);

            if (theBudget >= totalAmountMoney)
            {
                Console.WriteLine("YES \\ Left: {0:F2} lv.",finalCount);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:F2} lv.", finalCount);
            }
        }
    }
}
