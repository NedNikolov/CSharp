using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BRA
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int bra = n;

            string dashes = new string('-', bra/2);
            string asterixes = new string('*', bra + 2);
            int asterixe = 1;
            string asterix = new string('*', asterixe);
            string dash = new string('-', bra);

                Console.WriteLine(dashes + asterixes + dashes);
                for (int i = 1; i < bra; i++)
                {
                    Console.Write(dashes);
                    Console.Write(asterix);
                    Console.Write(dash);
                    Console.Write(asterix);
                    Console.Write(dashes);
                    Console.WriteLine();

                }
            int dashess = n/2;
            int middleDash = n;
            int starShip = 1;
            dashess++;
            middleDash += 2;
            starShip -= 2;
            for (int i = 0; i < bra; i++)
            {
                if (i <= bra/2)
                {
                    dashess--;
                    middleDash -= 2;
                    starShip += 2;
                    Console.Write(new string('-',dashess));
                    Console.Write(new string('*', starShip));
                    Console.Write(new string('-',middleDash));
                    Console.Write(new string('*', starShip));
                    Console.Write(new string('-',dashess));
                    Console.WriteLine();



                }
                else
                {
                    dashess++;
                    middleDash += 2;
                    starShip -= 2;
                    Console.Write(new string('-', dashess));
                    Console.Write(new string('*', starShip));
                    Console.Write(new string('-', middleDash));
                    Console.Write(new string('*', starShip));
                    Console.Write(new string('-', dashess));
                    Console.WriteLine();

                }
            }

        }
    }
}
