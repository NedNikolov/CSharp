using System;
using System.Linq;

namespace _14.MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());


            for (char firstLetter = a; firstLetter <= b; firstLetter++)
            {
                for (char secondLetter = a; secondLetter <= b; secondLetter++)
                {
                    for (char thirdLetter = a; thirdLetter <= b; thirdLetter++)
                    {
                        string word = firstLetter.ToString() + secondLetter.ToString() + thirdLetter.ToString();
                        if (!word.Contains(c))
                        {
                            Console.Write(word + " ");
                        }

                    }
                }
            }
        }
    }
}
