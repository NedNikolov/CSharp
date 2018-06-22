using System;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }

            Console.WriteLine(result);
        }
    }
}
