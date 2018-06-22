using System;

namespace _01.MultiplyEvenByOdds
{
    class MultiplyEvenByOdds
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var result = GetMultipleOfEvensAndOdds(num);
            Console.WriteLine(result);
        }
        static long GetMultipleOfEvensAndOdds(int num)
        {
            var product = GetSumOfOddDigits(num) * GetSumOfEvenDigits(num);
            return product;
        }
        static long GetSumOfEvenDigits(int num)
        {
            long sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var currentDigit = num % 10;
                if (currentDigit % 2 == 0)
                    sum += currentDigit;

                num /= 10;
            }

            return sum;
        }
        static long GetSumOfOddDigits(int num)
        {
            long sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var currentDigit = num % 10;
                if (currentDigit % 2 != 0)
                    sum += currentDigit;

                num /= 10;
            }

            return sum;
        }


    }
}
