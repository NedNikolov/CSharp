using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CapitalizeWords
{
    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            var symbols = new char[] { '.', ',', '-', '_', '!', '"', '?', ':', ';', '(', ')', '{', '}', '[', ']', '§'

                , '$', '%', '&', '/', '\\', '=', '|', '^', '°', '*', '#', '+', '~', '²', '³', '<', '>', ' '};

            var currentSentense = Console.ReadLine().ToLower().Split(symbols, StringSplitOptions.RemoveEmptyEntries).ToList(); ;

            while (currentSentense[0] != "end")
            {
                var newSentence = new List<string>();

                foreach (var symbol in currentSentense)
                {
                    var newWord = string.Empty;
                    for (int singht = 0; singht < symbol.Length; singht++)
                    {
                        var currChar = symbol[singht].ToString();
                        if (singht == 0)
                        {
                            currChar = symbol[singht].ToString().ToUpper();
                        }

                        newWord += currChar;
                    }

                    newSentence.Add(newWord);
                }

                Console.WriteLine(string.Join(", ", newSentence));

                currentSentense = Console.ReadLine().ToLower()
                    .Split(symbols, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

        }
    }
}
