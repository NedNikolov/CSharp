using System;
using System.Linq;

class ParkingFeud
{
    static int row;
    static int col;

    static void Main()
    {
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

        row = size[0];
        col = size[1];

        int entrance = int.Parse(Console.ReadLine());

        int totalSteps = 0;

        while (true)
        {
            string[] input = Console.ReadLine().Split();
            string samSpot = input[entrance - 1];
            bool isParked = true;

            int currentSamSteps = GetSteps(entrance, samSpot);

            for (int i = 0; i < input.Length; i++)
            {
                bool isSameSpot = input[i] == samSpot;
                bool isDiffRows = i + 1 != entrance;

                if (isDiffRows && isSameSpot)
                {
                    int enemySteps = GetSteps(i + 1, input[i]);
                    if (enemySteps < currentSamSteps)
                    {
                        totalSteps += currentSamSteps * 2;
                        isParked = false;
                        break;
                    }
                }
            }

            if (isParked)
            {
                Console.WriteLine($"Parked successfully at {samSpot}.");
                Console.WriteLine($"Total Distance Passed: {totalSteps}");
            }
        }

    }

    private static int GetSteps(int inputRow, string samSpot)
    {
        int targetRow = int.Parse(samSpot.Substring(1));
        int targetCol = samSpot[0] - 'A' + 1;
        int currSteps = 0;
        bool isRigt = true;

        while (targetRow != inputRow && targetRow - 1 != inputRow)
        {
            currSteps += col + 3;

            if (inputRow > targetRow)
            {
                inputRow--;
            }

            if (inputRow < targetRow)
            {
                inputRow++;
            }
        }
        isRigt = !isRigt;

        if (isRigt)
        {
            currSteps += targetCol;
        }
        else
        {
            currSteps += col - targetCol + 1;
        }

        return currSteps;
    }
}