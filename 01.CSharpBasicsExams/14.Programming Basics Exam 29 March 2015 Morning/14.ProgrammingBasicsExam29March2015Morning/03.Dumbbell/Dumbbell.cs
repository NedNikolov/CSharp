using System;

class Dumbbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char and = '&';
        char dash = '=';
        char star = '*';
        int leftDots = n/2 - 1;
        int leftStar = n/2;

        Console.Write(new string(dot, n/2));
        Console.Write(new string(and, n/2+1));
        Console.Write(new string(dot, n));
        Console.Write(new string(and, n / 2+1));
        Console.Write(new string(dot, n / 2));
        Console.WriteLine();

        for (int i = 1; i < n/2; i++)
        {
            Console.Write(new string(dot, leftDots));
            Console.Write(new string(and, 1));
            Console.Write(new string(star, leftStar));
            Console.Write(new string(and, 1));
            Console.Write(new string(dot, n));
            Console.Write(new string(and, 1));
            Console.Write(new string(star, leftStar));
            Console.Write(new string(and, 1));
            Console.Write(new string(dot, leftDots));
            Console.WriteLine();
            leftDots--;
            leftStar++;
        }


        Console.Write(new string(and, 1));
        Console.Write(new string(star, leftStar));
        Console.Write(new string(and, 1));
        Console.Write(new string(dash, n));
        Console.Write(new string(and, 1));
        Console.Write(new string(star, leftStar));
        Console.Write(new string(and, 1));

        Console.WriteLine();

        leftDots++;
        leftStar--;
        for (int i = 1; i < n / 2; i++)
        {
            Console.Write(new string(dot, leftDots));
            Console.Write(new string(and, 1));
            Console.Write(new string(star, leftStar));
            Console.Write(new string(and, 1));
            Console.Write(new string(dot, n));
            Console.Write(new string(and, 1));
            Console.Write(new string(star, leftStar));
            Console.Write(new string(and, 1));
            Console.Write(new string(dot, leftDots));
            Console.WriteLine();
            leftDots++;
            leftStar--;
        }

        Console.Write(new string(dot, n / 2));
        Console.Write(new string(and, n / 2 + 1));
        Console.Write(new string(dot, n));
        Console.Write(new string(and, n / 2 + 1));
        Console.Write(new string(dot, n / 2));
        Console.WriteLine();
    }
}