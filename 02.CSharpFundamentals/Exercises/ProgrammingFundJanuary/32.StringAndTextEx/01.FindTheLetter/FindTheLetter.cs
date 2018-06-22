using System;

namespace _01.FindTheLetter
{
    class FindTheLetter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var result = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string letter = result[0];
            int number = int.Parse(result[1]);

            var occurrenceIndex = -1;

            for (int i = 0; i < number; i++)
            {
                occurrenceIndex = input.IndexOf(letter, occurrenceIndex + 1);
            }

            if (occurrenceIndex >= 0)
            {
                Console.WriteLine("{0}", occurrenceIndex);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
