using System;

class DrawFigure
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char star = '*';
        char dot = '.';
        int leftdots = n + ((n/2) + 1);
        int middleDot = 1;
        int strangeDot = 0;

        Console.Write(  new string(dot, leftdots));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, leftdots));
        Console.WriteLine(  );

        for (int i = 0; i < n/2+1; i++)
        {
            leftdots--;
            Console.Write(new string(dot, leftdots));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, middleDot));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, leftdots));
            Console.WriteLine(  );
            middleDot += 2;
        }

        Console.Write(new string(star, leftdots));
        Console.Write(new string(dot, middleDot));
        Console.Write(new string(star, leftdots));
        Console.WriteLine(  );

        leftdots = 1;
        middleDot = n*3 - 2;
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string(dot, leftdots));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, middleDot));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, leftdots));
            Console.WriteLine(  );
            leftdots++;
            middleDot -= 2;
        }
        leftdots-=2;

        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string(dot, leftdots));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, n/2));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, strangeDot));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, n));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, strangeDot));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, n / 2));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, leftdots));
            Console.WriteLine();
            leftdots --;
            strangeDot++;
        }


        Console.Write(new string(star, n / 2 + 1));
        Console.Write(new string(dot, strangeDot));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, n));
        Console.Write(new string(star, 1));
        Console.Write(new string(dot, strangeDot));
        Console.Write(new string(star, n / 2 + 1));
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(dot, n));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, n));
            Console.Write(new string(star, 1));
            Console.Write(new string(dot, n));
            Console.WriteLine();
        }

            Console.Write(new string(dot, n));
            Console.Write(new string(star, n+2));
            Console.Write(new string(dot, n));
            Console.WriteLine();

    }
}