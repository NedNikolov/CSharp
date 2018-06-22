using System;

namespace _02.TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        
                        Console.WriteLine("{0}{1}{2}", (char)(a + 'a'), (char)(b + 'a'), (char)(c + 'a'));

                    }
                }
            }
        }
    }
}
