using System;

namespace _03.ExactProductRealNum
{
    class ExactProductRealNum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 1;

            for (int i = 1; i <= n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum *= num;
            }

            Console.WriteLine(sum);
        }
    }
}
