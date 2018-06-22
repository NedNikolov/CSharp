using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dash = '-';
        char star = '*';
        int frontDash = n / 2;
        int cicleLenght = frontDash - 1;
        int stars = 1;
        int cicleStar = 1;

        Console.Write(new string(dash, frontDash));
        Console.Write(new string(star, stars));
        Console.Write(new string(dash, frontDash));
        Console.WriteLine();
        for (int i = 0; i <= frontDash -1; i++)
        {
        Console.Write(new string(dash, cicleLenght));
        Console.Write(new string(star, stars));
        Console.Write(new string(dash, cicleStar));
        Console.Write(new string(star, stars));
        Console.Write(new string(dash, cicleLenght));
        Console.WriteLine();
        cicleLenght--;
        cicleStar += 2;
        }

        cicleLenght++;
        cicleStar -= 2;
        for (int i = 0; i < frontDash - 1; i++)
        {
        cicleLenght++;
        cicleStar -= 2;
        Console.Write(new string(dash, cicleLenght));
        Console.Write(new string(star, stars));
        Console.Write(new string(dash, cicleStar));
        Console.Write(new string(star, stars));
        Console.Write(new string(dash, cicleLenght));
        Console.WriteLine();
        }

        Console.Write(new string(dash, frontDash));
        Console.Write(new string(star, stars));
        Console.Write(new string(dash, frontDash));
        Console.WriteLine();

    }
}

