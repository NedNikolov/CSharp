using System;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';
        int cupe = n / 2 - 1;
        int cupe2 = n /2 - 2;
        int frontDot = n - 1;
        int allLong = n * 3;
        int insideCar = n;

        Console.Write(new string(dot, n));
        Console.Write(new string(star, n));
        Console.Write(new string(dot, n));
        Console.WriteLine();

        for (int i = 0; i < cupe; i++)
        {
            Console.Write(new string(dot, frontDot));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, insideCar));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, frontDot));
            Console.WriteLine();
            frontDot--;
            insideCar += 2;
        }

        frontDot++;
        Console.Write(new string(star, frontDot));
        Console.Write(new string(dot, insideCar));
        Console.Write(new string(star, frontDot));
        Console.WriteLine();

        for (int i = 0; i < cupe2; i++)
        {
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, allLong - 2));
        Console.Write(new string(star, 1));
        Console.WriteLine();
        }

        Console.WriteLine(new string(star, allLong));

        for (int i = 0; i < cupe2; i++)
        {
            Console.Write(new string(dot, n/2));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, cupe));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, (allLong-((n+4)+(cupe * 2)))));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, cupe));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, n/2));
            Console.WriteLine();
        }

        Console.Write(new string(dot, n / 2));
        Console.Write(new string(star, cupe + 2));
        Console.Write(new string(dot, (allLong - ((n + 4) + (cupe * 2)))));
        Console.Write(new string(star, cupe + 2));
        Console.Write(new string(dot, n / 2));
        Console.WriteLine();
    }
}

