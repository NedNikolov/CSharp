using System;

namespace _06.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {

            int maxNumber = int.Parse(Console.ReadLine());        

            for (int i = 1; i <= maxNumber; i++)
            {
                int currentNumber = i;
                int sum = 0;

                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                var result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {result}");
                
            }
        }
    }
}
