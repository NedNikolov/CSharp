using System;

namespace _14.ASCIIString
{
    class ASCIIString
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = "";

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                char symbol = (char) number;
                text += symbol;
            }
            Console.WriteLine(text);
        }
    }
}
