using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.lsnCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long lettersSum = 0;
            long symbolsSum = 0;
            long numbersSum = 0;

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();

            inputLine = inputLine.ToUpper();

            inputLine = Regex.Replace(inputLine, "\\s+", "");

                for (int j = 0; j < inputLine.Length; j++)
                {
                    char currentChar = inputLine[j];
                    if (currentChar >= 'A' && currentChar <= 'Z')
                    {
                        // Letters [a-zA-z]
                        lettersSum += (currentChar - 'A' + 1) * 10;
                    }
                    else if (currentChar >= '0' && currentChar <= '9')
                    {
                        // Numbers [0-9]
                        numbersSum += (currentChar - '0') * 20;
                    }
                    else
                    {
                        // Symbols
                        symbolsSum += 200;
                    }
                }
            }
            Console.WriteLine(lettersSum);
            Console.WriteLine(numbersSum);
            Console.WriteLine(symbolsSum);
        }
    }
}
