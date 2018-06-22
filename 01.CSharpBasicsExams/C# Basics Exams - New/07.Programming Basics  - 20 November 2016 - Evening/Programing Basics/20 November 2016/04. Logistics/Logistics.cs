using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sumTovar = 0;
            double microbus = 0;
            double truck = 0;
            double train = 0;


            for (int i = 1; i <= n; i++)
            {
                var tovar = int.Parse(Console.ReadLine());
                sumTovar = sumTovar + tovar;

                if (tovar <= 3)
                {
                    microbus += tovar; 
                }
                else if (tovar >= 4 && tovar <= 11)
                {
                    truck += tovar;
                }
                else if (tovar > 11)
                {
                    train += tovar;
                }

            }
            var allTovar = ((microbus * 200) + (truck * 175) + (train * 120)) / sumTovar;
            var microbuss = (microbus /sumTovar) * 100;
            var truckk = (truck / sumTovar) * 100;
            var trainn = (train / sumTovar) * 100;
            
            Console.WriteLine("{0:f2}",allTovar);
            Console.WriteLine("{0:f2}%",microbuss);
            Console.WriteLine("{0:f2}%",truckk);
            Console.WriteLine("{0:f2}%",trainn);
           
            
        }
    }
}
