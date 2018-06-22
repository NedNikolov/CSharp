using System;

namespace _03.StringRepeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string stringValue = Console.ReadLine();
            int intValue = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(stringValue, intValue));
        }

        static string RepeatString(string input, int n)
        {
            string newString = "";
            for (int i = 1; i <= n; i++)
            {
                newString += input;
            }
            return newString;
        }
    }
}
