using System;

class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';
        int allLine = n * 3;
        int firstDots = (allLine / 2);
        int cicleStar = 1;
        int cicleLenght = n - 1;
        int cicleDots = (allLine - 5) / 2;


        Console.Write(new string(dot,firstDots));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, firstDots));
        Console.WriteLine();

        for (int i = 0; i < cicleLenght; i++)
        {
        Console.Write(new string(dot, cicleStar));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, cicleDots));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, cicleDots));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, cicleStar));
        Console.WriteLine();
        cicleStar++;
        cicleDots--;
        }


        for (int i = 0; i < n / 2; i++)
        {
        Console.Write(new string(dot, n));
        Console.Write(new string(star, n));
        Console.Write(new string(dot, n));
        Console.WriteLine();
        }

        Console.WriteLine(new string(star, allLine));

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string(dot, n));
            Console.Write(new string(star, n));
            Console.Write(new string(dot, n));
            Console.WriteLine();
        }


        cicleStar--;
        cicleDots++;
        for (int i = 0; i < cicleLenght; i++)
        {
            Console.Write(new string(dot, cicleStar));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, cicleDots));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, cicleDots));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, cicleStar));
            Console.WriteLine();
            cicleStar--;
            cicleDots++;
        }
    }
}

