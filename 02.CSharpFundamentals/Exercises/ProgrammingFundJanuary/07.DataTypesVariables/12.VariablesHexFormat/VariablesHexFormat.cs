using System;

namespace _12.VariablesHexFormat
{
    class VariablesHexFormat
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int result = Convert.ToInt32(input, 16);
            Console.WriteLine(result);
        }
    }
}
