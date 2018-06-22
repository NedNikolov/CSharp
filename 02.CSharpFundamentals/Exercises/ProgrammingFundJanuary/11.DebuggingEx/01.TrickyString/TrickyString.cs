using System;

namespace _01.TrickyString
{
    class TrickyString
    {
        static void Main()
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());

            var result = string.Empty;
            var currentString = string.Empty;

            for (int i = 1; i <= numberOfStrings - 1; i++)
            {
                currentString = Console.ReadLine();
                result += currentString + delimiter;
                
            }
            currentString = Console.ReadLine();
            result += currentString;

            Console.WriteLine(result);
        }
    }
}
