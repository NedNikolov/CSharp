using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dots = n / 2;
        int dots2 = n - 2;
        int dots3 = (n / 2) + 1;
        char symbol = '#';
        int dots4 = 1;
        int sum = ((dots * 2) + n) - 4;

        Console.Write(new string('.', dots));
        Console.Write(new string(symbol, n));
        Console.Write(new string('.', dots));
        Console.WriteLine();
        for (int i = 0; i < dots2; i++)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string(symbol, 1));
            Console.Write(new string('.', dots2));
            Console.Write(new string(symbol, 1));
            Console.Write(new string('.', dots));
            Console.WriteLine();
        }

        Console.Write(new string(symbol, dots3));
        Console.Write(new string('.', dots2));
        Console.Write(new string(symbol, dots3));
        Console.WriteLine();

        for (int i = 0; i <= dots2; i++)
        {
            if (sum >= 0)
            {
                Console.Write(new string('.', dots4));
                Console.Write(new string(symbol, 1));
                Console.Write(new string('.', sum));
                Console.Write(new string(symbol, 1));
                Console.Write(new string('.', dots4));
                Console.WriteLine();
                dots4++;
                sum -= 2;
            }
            else
            {
                Console.Write(new string('.', dots4));
                Console.Write(new string(symbol, 1));
                Console.Write(new string('.', dots4));
                Console.WriteLine();
                dots4++;
                sum -= 2;
            }
        }


    }
}

