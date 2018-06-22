using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendList
{
    class AppendList
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').ToList();
            numbers.Reverse();
            var result = new List<string>();

            foreach (var number in numbers)
            {
                List<string> nums = number.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
            }
            Console.WriteLine(string.Join(" ", result));

            
        }
    }
}
