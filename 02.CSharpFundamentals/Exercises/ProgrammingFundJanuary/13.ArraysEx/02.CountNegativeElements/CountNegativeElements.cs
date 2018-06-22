using System;

namespace _02.CountNegativeElements
{
    class CountNegativeElements
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int negativeNum = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < 0)
                {
                    negativeNum++;
                }
            }
            Console.WriteLine(negativeNum);
        }
    }
}
