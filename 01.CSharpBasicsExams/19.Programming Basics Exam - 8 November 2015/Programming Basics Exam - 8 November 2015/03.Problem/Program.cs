using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalNumberOfCandidateList = int.Parse(Console.ReadLine());
            int theVoteOfElector = int.Parse(Console.ReadLine());
            string votingSymbol = Console.ReadLine();

            for (int i = 1; i <= totalNumberOfCandidateList; i++)
            {
                if (theVoteOfElector == i)
                {
                    if (votingSymbol == "X" || votingSymbol == "x")
                    {
                        Console.WriteLine(new string('.', 13));
                        Console.Write(new string('.', 3));
                        Console.Write(new string('+', 1));
                        Console.Write(new string('-', 5));
                        Console.Write(new string('+', 1));
                        Console.WriteLine(new string('.', 3));
                        Console.Write(new string('.', 3));
                        Console.Write(new string('|', 1));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('\\', 1));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('/', 1));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('|', 1));
                        Console.WriteLine(new string('.', 3));
                        Console.Write("{0:D2}", i);
                        Console.Write(new string('.', 1));
                        Console.Write(new string('|', 1));
                        Console.Write(new string('.', 2));
                        Console.Write(new string('X', 1));
                        Console.Write(new string('.', 2));
                        Console.Write(new string('|', 1));
                        Console.WriteLine(new string('.', 3));

                        Console.Write(new string('.', 3));
                        Console.Write(new string('|', 1));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('/', 1));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('\\', 1));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('|', 1));
                        Console.WriteLine(new string('.', 3));

                        Console.Write(new string('.', 3));
                        Console.Write(new string('+', 1));
                        Console.Write(new string('-', 5));
                        Console.Write(new string('+', 1));
                        Console.WriteLine(new string('.', 3));
                    }

                    else
                    {
                        Console.WriteLine(new string('.', 13));
                        Console.Write(new string('.', 3));
                        Console.Write(new string('+', 1));
                        Console.Write(new string('-', 5));
                        Console.Write(new string('+', 1));
                        Console.WriteLine(new string('.', 3));
                        Console.Write(new string('.', 3));
                        Console.Write(new string('|', 1));
                        Console.Write(new string('\\', 1));
                        Console.Write(new string('.', 3));
                        Console.Write(new string('/', 1));
                        Console.Write(new string('|', 1));
                        Console.WriteLine(new string('.', 3));
                        Console.Write("{0:D2}", i);
                        Console.Write(new string('.', 1));
                        Console.Write(new string('|', 1));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('\\', 1));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('/', 1));
                        Console.Write(new string('.', 1));
                        Console.Write(new string('|', 1));
                        Console.WriteLine(new string('.', 3));

                        Console.Write(new string('.', 3));
                        Console.Write(new string('|', 1));
                        Console.Write(new string('.', 2));
                        Console.Write(new string('V', 1));
                        Console.Write(new string('.', 2));
                        Console.Write(new string('|', 1));
                        Console.WriteLine(new string('.', 3));

                        Console.Write(new string('.', 3));
                        Console.Write(new string('+', 1));
                        Console.Write(new string('-', 5));
                        Console.Write(new string('+', 1));
                        Console.WriteLine(new string('.', 3));

                    }
                    

                }
                else
                {
                    Console.WriteLine(new string('.', 13));
                    Console.Write(new string('.', 3));
                    Console.Write(new string('+', 1));
                    Console.Write(new string('-', 5));
                    Console.Write(new string('+', 1));
                    Console.WriteLine(new string('.', 3));
                    Console.Write(new string('.', 3));
                    Console.Write(new string('|', 1));
                    Console.Write(new string('.', 5));
                    Console.Write(new string('|', 1));
                    Console.WriteLine(new string('.', 3));
                    Console.Write("{0:D2}", i);
                    Console.Write(new string('.', 1));
                    Console.Write(new string('|', 1));
                    Console.Write(new string('.', 5));
                    Console.Write(new string('|', 1));
                    Console.WriteLine(new string('.', 3));

                    Console.Write(new string('.', 3));
                    Console.Write(new string('|', 1));
                    Console.Write(new string('.', 5)); ;
                    Console.Write(new string('|', 1));
                    Console.WriteLine(new string('.', 3));

                    Console.Write(new string('.', 3));
                    Console.Write(new string('+', 1));
                    Console.Write(new string('-', 5));
                    Console.Write(new string('+', 1));
                    Console.WriteLine(new string('.', 3));
                }
            }
            Console.WriteLine(new string('.', 13));
        }
    }
}
