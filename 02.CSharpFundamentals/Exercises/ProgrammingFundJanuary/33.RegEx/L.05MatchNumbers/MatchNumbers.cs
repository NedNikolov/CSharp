using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace L._05MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");
            var currentNumbers = regex.Matches(Console.ReadLine());

            foreach (var number in currentNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
