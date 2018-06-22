using System;

class Disk
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());
        int diskCenterRow = size / 2;
        int diskCenterCol = size / 2;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                int deltaX = col - diskCenterCol;
                int deltaY = row - diskCenterRow;
                double distanceToCenter = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                bool isWithinDisk = distanceToCenter <= radius;

                if (isWithinDisk)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}

