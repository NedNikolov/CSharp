using System;

public class StartUp
{
    public static void Main()
    {
        var size = int.Parse(Console.ReadLine());
        for (int startCount = 1; startCount <= size; startCount++)
        {
            PrintRow(size, startCount);
        }
        for (int startCount = size - 1; startCount >= 1; startCount--)
        {
            PrintRow(size, startCount);
        }
    }

    static void PrintRow(int figuresize, int startCount)
    {
        for (int i = 0; i < figuresize - startCount; i++)
        {
            Console.Write(" ");
        }
        for (int col = 1; col < startCount; col++)
        {
            Console.Write("* ");
        }
        Console.WriteLine("*");
    }
}

