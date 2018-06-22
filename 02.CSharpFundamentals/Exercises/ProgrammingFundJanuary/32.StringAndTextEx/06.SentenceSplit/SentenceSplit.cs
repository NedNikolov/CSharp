using System;

namespace _06.SentenceSplit
{
    class SentenceSplit
    {
        static void Main(string[] args)
        {
            var sentenses = Console.ReadLine();
            var delimiter = Console.ReadLine();

            sentenses = sentenses.Replace(delimiter, ", ");
            Console.WriteLine($"[{sentenses}]");
        }
    }
}
