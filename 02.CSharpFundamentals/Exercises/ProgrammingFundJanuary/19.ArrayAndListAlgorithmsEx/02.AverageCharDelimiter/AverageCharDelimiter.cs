using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageCharDelimiter
{
    class AverageCharDelimiter
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ').ToList();
            double totalSum = 0;
            double countOfCharacters = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                string word = elements[i];
                countOfCharacters += word.Length;
                for (int j = 0; j < elements[i].Length; j++)
                {
                    totalSum += word[j];
                } 
            }

            char charDelimiter = (char)((int)(totalSum / countOfCharacters));
            string delimiter = charDelimiter.ToString().ToUpper();

            Console.WriteLine(string.Join(delimiter, elements));

            /* var givenSequence = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var arrayToString = string.Join(string.Empty, givenSequence);
            var averageSymbolSum = 0.0;
            var symbolCounter = arrayToString.Length;
            for (int counter = 0; counter < symbolCounter; counter++)
            {
                averageSymbolSum += arrayToString[counter];
            }
            Math.Ceiling(averageSymbolSum /= symbolCounter);
            var delimiter = (char)averageSymbolSum;
            Console.WriteLine(string.Join($"{delimiter.ToString().ToUpper()}", givenSequence));   */

        }
    }
}
