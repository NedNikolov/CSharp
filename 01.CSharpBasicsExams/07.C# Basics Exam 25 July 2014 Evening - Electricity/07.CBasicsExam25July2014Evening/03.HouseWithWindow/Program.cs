using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';
        int sky = n - 1;

        int topFloor = sky + n;
        int leftRoof = (topFloor /2)- 1;
        int middleRoof = 1;

        Console.Write(new string(dot, sky));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, sky));
        Console.WriteLine();

        for (int i = 0; i < sky; i++)
        {
        Console.Write(new string(dot, leftRoof));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, middleRoof));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, leftRoof));
        Console.WriteLine();
        leftRoof--;
        middleRoof += 2;
        }

        Console.Write(new string(star, topFloor));
        Console.WriteLine();

        for (int i = 0; i < n/4; i++)
        {
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, topFloor-2));
        Console.Write(new string(star, 1));
        Console.WriteLine();
        }

        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, n/2));
            Console.Write(new string(star, (topFloor-((((n/2)*2))+2))));
            Console.Write(new string(dot, n/ 2));
            Console.Write(new string(star, 1));
            Console.WriteLine();
        }

        for (int i = 0; i < n / 4; i++)
        {
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, topFloor - 2));
            Console.Write(new string(star, 1));
            Console.WriteLine();
        }

        Console.Write(new string(star, topFloor));
        Console.WriteLine();
    }
}

