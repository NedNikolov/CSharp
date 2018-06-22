using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dash = '-';
        char symbol = '*';
        char line = '|';
        int leftRoof = n / 2;
        int topRoof = 1;
        int walls = 1;
        int roofLong = n / 2;
        int topFloor = (leftRoof * 2) + topRoof;

        for (int i = 0; i <= roofLong; i++)
        {
            Console.Write(new string(dash,leftRoof));
            Console.Write(new string(symbol, topRoof));
            Console.Write(new string(dash, leftRoof));
            Console.WriteLine();
            topRoof += 2;
            leftRoof--;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(line,walls));
            Console.Write(new string(symbol, n-2));
            Console.Write(new string(line, walls));
            Console.WriteLine();
        }
    }
}

