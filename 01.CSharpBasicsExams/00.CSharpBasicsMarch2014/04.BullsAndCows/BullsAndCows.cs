using System;

class BullsAndCows
{
    static void Main()
    {
        //int secretNumber = 2228;
        //int bulls = 2;
        //int cows = 1;
        //for (int guessNumber = 1111; guessNumber < 9999; guessNumber++)
        //{
        //    int bullFound = GetBulls(secretNumber, guessNumber);
        //    int cowFound = GetCows(secretNumber, guessNumber);
        //    if (bulls== bullFound && cows == cowFound)
        //    {

        //        Console.Write(guessNumber);
        //        Console.Write(" ");
        //    }

        //}
        Console.WriteLine(GetCows(1234,1345));
    }

    private static string GetCows(int secretNumber, int guessNumber)
    {
        string secretNum = secretNumber.ToString().PadLeft(4, '0');
        string guessNum = guessNumber.ToString().PadLeft(4, '0');
        int bullCount = 0;
        for (int i = 0; i < 4; i++)
        {
            if (secretNum[i] == guessNum[i])
            {
                secretNum[i] = '*';
                guessNum[i] = '*';
            }
        }
        return bullCount;
    }

    private static int GetBulls(int secretNumber,int guessNumber)
    {
        string secretNum = secretNumber.ToString().PadLeft(4, '0');
        string guessNum = guessNumber.ToString().PadLeft(4, '0');
        int bullCount = 0;
        for (int i = 0; i < 4; i++)
        {
            if (secretNum[i] == guessNum[i])
            {
                bullCount++;
            }
        }
        return bullCount;
    }
}

