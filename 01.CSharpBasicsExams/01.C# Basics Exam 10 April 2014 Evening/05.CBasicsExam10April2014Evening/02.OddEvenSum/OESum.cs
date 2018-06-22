using System;

namespace _02.OddEvenSum
{
    class OESum
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int firstCicle = count * 2;
            int odd = 0;
            int even = 0;
            for (int i = 1; i <= firstCicle; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    odd = odd + numbers;
                }
                else
                {
                    even = even + numbers;
                }          
            }

            int result = Math.Abs(odd - even);
            if (odd > even)
            {
                Console.WriteLine("No, diff={0}", result);
            }
            else if (odd < even)
            {
                Console.WriteLine("No, diff={0}", result);
            }
            else
            {
                Console.WriteLine("Yes, sum={0}", even);
            }
        }
    }
}
