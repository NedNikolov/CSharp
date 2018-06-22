using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] delimiter = new char[]
                {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};

            string[] words = Console.ReadLine()
                .ToLower()
                .Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w).ToArray();

            Console.WriteLine(string.Join(", ", words));


        }
    }
}
