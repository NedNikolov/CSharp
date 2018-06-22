using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int workHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int productivity = int.Parse(Console.ReadLine());

            double percent = productivity * 0.01;
            double realDays = (double)days * 0.90d;
            double neededHours = realDays * 12;
            double realHours = neededHours*percent;
            double differences = workHours - Math.Floor(realHours);

            if (differences > 0)
            {
                Console.WriteLine("No");
                Console.WriteLine("-{0}", differences);
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0}", Math.Abs(differences));
            }
        }
    }
}
