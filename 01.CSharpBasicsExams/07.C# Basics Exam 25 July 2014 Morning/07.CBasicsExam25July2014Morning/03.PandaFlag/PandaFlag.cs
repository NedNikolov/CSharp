using System;

class PandaFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char syllable = 'A';
        char cell = '#';
        char space = '~';
        int spaceSize = 0;
        int cellSize = n - 2;
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string(space, spaceSize));
            Console.Write(syllable);
            syllable = GetLetter(syllable);
            Console.Write(new string(cell, cellSize));
            cellSize -= 2;
            Console.Write(syllable);
            Console.Write(new string(space, spaceSize));
            syllable = GetLetter(syllable);
            spaceSize++;
            Console.WriteLine();
        }
        Console.Write(new string('-', spaceSize));
        Console.Write(new string(syllable, 1));
        Console.Write(new string('-', spaceSize));
        Console.WriteLine();

        cellSize += 2;
        spaceSize--;

        for (int i = 0; i < n/2; i++)
        {
            syllable = GetLetter(syllable);
            Console.Write(new string(space, spaceSize));
            Console.Write(syllable);
            syllable = GetLetter(syllable);
            Console.Write(new string(cell, cellSize));
            cellSize += 2;
            Console.Write(syllable);
            Console.Write(new string(space, spaceSize));
            spaceSize--;
            Console.WriteLine();

        }
    }
    static char GetLetter(char syllable)
    {
        syllable++;
            if (syllable > 'Z')
	{
        syllable = 'A';
	}
            return syllable;
    }



}

