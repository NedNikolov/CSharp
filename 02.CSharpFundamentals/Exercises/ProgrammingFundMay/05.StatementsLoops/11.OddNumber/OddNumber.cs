using System;

namespace _11.OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(num));
                    break;
                }
            }
        }
    }
}
