using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace L._03MatchHexNumbers
{
    class MatchHexNumbers
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var regex = new Regex(pattern);
            var hexidecimalNumbers = regex.Matches(Console.ReadLine());

            foreach (var match in hexidecimalNumbers)
            {
                Console.Write($"{match} ");
            }
        }
    }
}
