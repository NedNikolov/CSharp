using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double car = 0;
            double microbus = 0;
            double minibus = 0;
            double bus = 0;
            double train = 0;
            double sumpeople = 0;

            for (int i = 1; i <= n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sumpeople = sumpeople + people;

                if (people <= 5)
                {
                    car += people;
                }

                else if (people >= 6 && people <= 12)
                {
                    microbus += people;
                }

                else if (people >= 13 && people <= 25)
                {
                    minibus += people;
                }

                else if (people >= 26 && people <= 40)
                {
                    bus += people;
                }

                else
                {
                    train += people;
                }

            }

            double carr = (car / sumpeople) * 100;
            double microbuss = (microbus / sumpeople) * 100;
            double minimuss = (minibus / sumpeople) * 100;
            double buss = (bus / sumpeople) * 100;
            double trainn = (train / sumpeople) * 100;

            Console.WriteLine("{0:f2}%", carr);
            Console.WriteLine("{0:f2}%", microbuss);
            Console.WriteLine("{0:f2}%", minimuss);
            Console.WriteLine("{0:f2}%", buss);
            Console.WriteLine("{0:f2}%", trainn);
        }
    }
}
