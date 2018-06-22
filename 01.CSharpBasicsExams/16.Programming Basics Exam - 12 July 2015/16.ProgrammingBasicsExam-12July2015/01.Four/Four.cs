using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Four
{
    class Four
    {
        static void Main(string[] args)
        {
            double fieldGoals = double.Parse(Console.ReadLine());
            double fGAttempls = double.Parse(Console.ReadLine());
            double pointFieldGoals = double.Parse(Console.ReadLine());
            double TurnOVer = double.Parse(Console.ReadLine());
            double OffenciveReBounds = double.Parse(Console.ReadLine());
            double opDeffReb = double.Parse(Console.ReadLine());
            double freeThrows = double.Parse(Console.ReadLine());
            double freeTA = double.Parse(Console.ReadLine());
            //3351 
            //7018 
            //796
            //1125
            //967
            //2550
            //1556
            //2080

            double efg = (fieldGoals + 0.5d * pointFieldGoals) / fGAttempls;
            double tov = TurnOVer / (fGAttempls + 0.44d * freeTA + TurnOVer);
            double orb = OffenciveReBounds / (OffenciveReBounds + opDeffReb);
            double ft = freeThrows / fGAttempls;

            Console.WriteLine("eFG% {0:0.000}", efg);
            Console.WriteLine("TOV% {0:0.000}", tov);
            Console.WriteLine("ORB% {0:0.000}", orb);
            Console.WriteLine("FT% {0:0.000}", ft);

            //eFG% = (3351 + 0.5 * 796) / 7018 = 0.534
            //TOV% = 1125 / (7018 + 0.44 * 2080 + 1125) = 0.124
            //ORB% = 967 / (967 + 2550) = 0.275
            //FT% = 1556 / 7018 = 0.222




            
        }
    }
}
