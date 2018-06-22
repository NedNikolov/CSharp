using System;

namespace _06.DNASequences
{
    class DNASequences
    {
        static void Main(string[] args)
        {
            int dna = int.Parse(Console.ReadLine());
            char[] charMapping = { '\0','A','C','G','T' };
            

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        char startChar = 'X';
                        if (i + j + k >= dna)
                        {
                            startChar = 'O';
                        }
                        Console.Write(startChar);
                        Console.Write(charMapping[i]);
                        Console.Write(charMapping[j]);
                        Console.Write(charMapping[k]);
                        Console.Write(startChar);
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
