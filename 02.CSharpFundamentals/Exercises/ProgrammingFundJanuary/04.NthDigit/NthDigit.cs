using System;

namespace _04.NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int nthDigit = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(num, nthDigit));


        }

        static int FindNthDigit(long number, int index)
        {
            int digit = 0;
            int count = 0;
            while (number > 0)
            {
                digit = (int) (number % 10);
                count++;
                if (count == index)
                {
                    break;
                }
                number = number / 10;

            }
            return digit;
        }
    }
}
