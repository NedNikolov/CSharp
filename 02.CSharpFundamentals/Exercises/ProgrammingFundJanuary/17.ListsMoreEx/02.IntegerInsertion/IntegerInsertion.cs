using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var num = Console.ReadLine();

            while (num != "end")
            {
                var place = Convert.ToInt16(num[0].ToString());
                numbers.Insert(place, int.Parse(num));
                num = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
