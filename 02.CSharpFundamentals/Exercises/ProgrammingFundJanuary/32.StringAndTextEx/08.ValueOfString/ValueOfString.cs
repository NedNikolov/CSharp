using System;

namespace _08.ValueOfString
{
    class ValueOfString
    {
        static int upperCaseSymbols;
        static int lowerCaseSymbols;

        static void Main(string[] args)
        {
            var someStringAsCharCollection = Console.ReadLine();
            var asciiSumUpperOrLowerCase = Console.ReadLine();

            SumAllLettersFromUpperAndLowerCase(someStringAsCharCollection);
            PrintResultByGivenASCIISumOperatorFrom(asciiSumUpperOrLowerCase);
        }

        static void SumAllLettersFromUpperAndLowerCase(string someStringAsCharCollection)
        {
            foreach (var letter in someStringAsCharCollection)
            {
                if (letter >= 'a' && letter <= 'z')
                {
                    lowerCaseSymbols += letter;
                }
                else if (letter >= 'A' && letter <= 'Z')
                {
                    upperCaseSymbols += letter;
                }
            }
        }

        static void PrintResultByGivenASCIISumOperatorFrom(string asciiSumUpperOrLowerCase)
        {
            Console.WriteLine(asciiSumUpperOrLowerCase == "LOWERCASE" ?
                $"The total sum is: {lowerCaseSymbols}" :
                $"The total sum is: {upperCaseSymbols}");
        }
    }
}
