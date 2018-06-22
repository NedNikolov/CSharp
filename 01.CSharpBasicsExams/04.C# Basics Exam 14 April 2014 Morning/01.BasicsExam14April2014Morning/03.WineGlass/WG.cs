using System;

class WineGlass
{
    const char GlassFillingSymbol = '*';
    const char EmptySpaceSymbol = '.';

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int borderSpacing = 0;
        int middleSpacing = n - 2;

        for (int i = 0; i < n; i++)
        {
            if (i < n / 2)
            {
                string dots = new string(EmptySpaceSymbol, borderSpacing);
                string asterisks = new string(GlassFillingSymbol, middleSpacing);
                Console.WriteLine(dots + '\\' + asterisks + '/' + dots);
                borderSpacing++;
                middleSpacing -= 2;
            }
            else if (n < 12 && i < n - 1 || n >= 12 && i < n - 2)
            {
                string dots = new string(EmptySpaceSymbol, n / 2 - 1);
                Console.WriteLine(dots + '|' + '|' + dots);
            }
            else
            {
                Console.WriteLine(new string('-', n));
            }
        }
    }
}
