using System;

class Towel
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char diez = '#';
        char dot = '.';
        int height = n / 2 + n;
        int width = n;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if ((i + j) % 3 == 0)
                {
                    Console.Write(diez);
                }
                else
                {
                    Console.Write(dot);
                }
            }
            Console.WriteLine();
        }

    }
}