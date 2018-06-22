using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            double kmPerHour = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());
            double firstTimeCalc = firstTime / 60;
            double secondTimeCalc = secondTime / 60;
            double thirdTimeCalc = thirdTime / 60;
            
            var startSpeed = kmPerHour * firstTimeCalc;
            var speed = (kmPerHour + (kmPerHour * 0.1));
            var speed1 = speed * 0.05;
            var afterSpeedU = speed * secondTimeCalc;
            var afterSpeedD = (speed - speed1) * thirdTimeCalc;
            var result = startSpeed + afterSpeedU + afterSpeedD;
            Console.WriteLine("{0:F2}",result);
        }
    }
}
