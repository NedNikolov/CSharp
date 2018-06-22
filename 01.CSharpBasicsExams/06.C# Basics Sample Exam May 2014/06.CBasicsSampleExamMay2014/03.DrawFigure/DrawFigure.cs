using System;

class DrawFigure
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char star = '*';
        char dot = '.';
        int sizeDot = 0;
        int sizeStar = n;

        for (int i = 0; i < n; i++)
        {
            if (i < n/2)
            {
                Console.Write(new string(dot, sizeDot));
                Console.Write(new string(star, sizeStar));
                Console.Write(new string(dot, sizeDot));
                Console.WriteLine(  );
                sizeDot++;
                sizeStar -= 2;
            }
            else
            {
                Console.Write(new string(dot, sizeDot));
                Console.Write(new string(star, sizeStar));
                Console.Write(new string(dot, sizeDot));
                Console.WriteLine(  );
                sizeDot--;
                sizeStar += 2;
            }
        }
    }
}

