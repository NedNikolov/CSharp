using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int size = n / 2;
        int roof = 1;
        int leftSize = (n / 2) - 1;
        int leftSize1 = (n / 2) - 1;
        int lastFloor = (size * 2) + 1;
        int roofDot = 1;
        int tree = n / 3;
        int four = n / 4;
        int final = n - (four + four);
        int hard = (n - (four + four)) -2;
        char dot = '.';
        char star = '*';

        Console.Write(new string(dot, size));
        Console.Write(new string(star, roof));
        Console.Write(new string(dot, size));
        Console.WriteLine();
        for (int i = 0; i < leftSize1; i++)
        {
        Console.Write(new string(dot, leftSize));
        Console.Write(new string(star, roof));
        Console.Write(new string(dot, roofDot));
        Console.Write(new string(star, roof));
        Console.Write(new string(dot, leftSize));
        Console.WriteLine();
        leftSize -= 1;
        roofDot+=2;
        }
        Console.Write(new string(star, lastFloor));
        Console.WriteLine();

        for (int i = 0; i < leftSize1; i++)
        {
        Console.Write(new string(dot, four));
        Console.Write(new string(star, roof));
        Console.Write(new string(dot, hard));
        Console.Write(new string(star, roof));
        Console.Write(new string(dot, four));
        Console.WriteLine();
        }
        Console.Write(new string(dot, four));
        Console.Write(new string(star, final));
        Console.Write(new string(dot, four));
        Console.WriteLine();
    }
}
