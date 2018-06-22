using System;

class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char star = '*';
        char wall = '|';
        char fall = '/';
        int firstStar = n + n;
        int borders = (n / 2) - 1;

        Console.Write(new string(star, firstStar));
        Console.Write(new string(' ', n));
        Console.Write(new string(star, firstStar));
        Console.WriteLine();

        for (int i = 0; i < borders; i++)
        {
            Console.Write(new string(star, 1));
            Console.Write(new string(fall, firstStar - 2));
            Console.Write(new string(star, 1));
            Console.Write(new string(' ', n));
            Console.Write(new string(star, 1));
            Console.Write(new string(fall, firstStar - 2));
            Console.Write(new string(star, 1));
            Console.WriteLine();
        }

        Console.Write(new string(star, 1));
        Console.Write(new string(fall, firstStar - 2));
        Console.Write(new string(star, 1));
        Console.Write(new string(wall, n));
        Console.Write(new string(star, 1));
        Console.Write(new string(fall, firstStar - 2));
        Console.Write(new string(star, 1));
        Console.WriteLine();

        for (int i = 0; i < borders; i++)
        {
            Console.Write(new string(star, 1));
            Console.Write(new string(fall, firstStar - 2));
            Console.Write(new string(star, 1));
            Console.Write(new string(' ', n));
            Console.Write(new string(star, 1));
            Console.Write(new string(fall, firstStar - 2));
            Console.Write(new string(star, 1));
            Console.WriteLine();
        }

        Console.Write(new string(star, firstStar));
        Console.Write(new string(' ', n));
        Console.Write(new string(star, firstStar));
        Console.WriteLine();

    }
}


