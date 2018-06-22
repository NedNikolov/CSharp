using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace L._01MatchFullNames
{
    class MatchFullNames
    {
        static void Main(string[] args)
        {
            var pattern = @"\b[A-Z][a-z]+\s{1}\b[A-Z][a-z]+";
            var regex = new Regex(pattern);
            var fullNames = regex.Matches(Console.ReadLine());

            foreach (var name in fullNames)
            {
                Console.Write(name + " ");
            }
        }
    }
}
