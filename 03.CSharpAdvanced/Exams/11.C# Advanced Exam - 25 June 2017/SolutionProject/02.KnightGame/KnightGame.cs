using System;
using System.Data;

class KnightGame
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        char[][] jaggedArray = new char[rows][];

        GetJaggedArrays(jaggedArray);
        int targetRow = 0;
        int targetCol = 0;
        int removedKnights = 0;

        while (true)
        {
            int maxAttacked = 0;

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    int attacked = 0;
                    if (jaggedArray[row][col] == 'K')
                    {
                        if (IsInside(jaggedArray, row - 2, col - 1) && jaggedArray[row - 2][col - 1] == 'K') //up left
                        {
                            attacked++;
                        }
                        if (IsInside(jaggedArray, row - 2, col + 1) && jaggedArray[row - 2][col + 1] == 'K') //up right
                        {
                            attacked++;
                        }
                        if (IsInside(jaggedArray, row + 2, col - 1) && jaggedArray[row + 2][col - 1] == 'K') // down left
                        {
                            attacked++;
                        }
                        if (IsInside(jaggedArray, row + 2, col + 1) && jaggedArray[row + 2][col + 1] == 'K') // down right
                        {
                            attacked++;
                        }
                        if (IsInside(jaggedArray, row - 1, col - 2) && jaggedArray[row - 1][col - 2] == 'K') // left up
                        {
                            attacked++;
                        }
                        if (IsInside(jaggedArray, row + 1, col - 2) && jaggedArray[row + 1][col - 2] == 'K') // left down
                        {
                            attacked++;
                        }
                        if (IsInside(jaggedArray, row - 1, col + 2) && jaggedArray[row - 1][col + 2] == 'K') // right up
                        {
                            attacked++;
                        }
                        if (IsInside(jaggedArray, row + 1, col + 2) && jaggedArray[row + 1][col + 2] == 'K') // left up
                        {
                            attacked++;
                        }
                    }

                    if (attacked > maxAttacked)
                    {
                        maxAttacked = attacked;
                        targetRow = row;
                        targetCol = col;
                    }
                }
            }

            if (maxAttacked > 0)
            {
                jaggedArray[targetRow][targetCol] = '0';
                removedKnights++;
            }
            else
            {
                Console.WriteLine(removedKnights);
                break;
            }

        }
    }

    private static bool IsInside(char[][] jaggedArray, int row, int col)
    {
        return row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray.Length;
    }

    private static void GetJaggedArrays(char[][] jaggedArray)
    {
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            jaggedArray[i] = Console.ReadLine().ToCharArray();
        }
    }
}



