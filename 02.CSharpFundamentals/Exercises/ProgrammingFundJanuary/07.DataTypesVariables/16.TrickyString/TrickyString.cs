using System;

namespace _16.TrickyString
{
    class TrickyString
    {
        static void Main(string[] args)
        {
            string firstSymbol = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string text = "";

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                if (input == String.Empty)
                {
                    text += firstSymbol;
                }
                else
                {
                    text += input;
                }
                if (i == n)
                {
                    break;
                }
                text += firstSymbol;
            }
            Console.WriteLine(text);
        }
    }
}
