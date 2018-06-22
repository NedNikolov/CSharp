using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int doc = 7;
            int treatedPacients = 0;
            int untreatedPacients = 0;


            for (int i = 1; i <= days; i++)
            {
                int pacients = int.Parse(Console.ReadLine());

                if (i == 3)
                {
                    if (untreatedPacients > treatedPacients)
                    {
                        doc++;

                    }
                }  

                if (pacients <= doc)
                {
                    treatedPacients = treatedPacients + pacients; 
                }
                else
                {
                    treatedPacients = treatedPacients + doc;
                    untreatedPacients = untreatedPacients + (pacients - doc);
                }

                          

            }


            Console.WriteLine("Treated patients: {0}." , treatedPacients);
            Console.WriteLine("Untreated patients: {0}." , untreatedPacients);
        }
    }
}
