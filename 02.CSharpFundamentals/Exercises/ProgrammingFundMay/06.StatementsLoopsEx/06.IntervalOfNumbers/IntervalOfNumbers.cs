using System;

namespace _06.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int third = 0;

            if (first > second)
            {
                third = first;
                first = second;
                second = third;
            }

            for (int i = first; i <= second; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
