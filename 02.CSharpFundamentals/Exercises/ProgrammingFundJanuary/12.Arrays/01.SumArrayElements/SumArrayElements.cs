using System;

namespace _01.SumArrayElements
{
    class SumArrayElements
    {
        static void Main(string[] args)
        {
            var numberOfElements = int.Parse(Console.ReadLine());
            var array = new int[numberOfElements];
            var sum = 0;


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }

            Console.WriteLine(sum);

        }


    }
}
