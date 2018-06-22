using System;

namespace _10.MultiplicationTable2
{
    class MultiplicationTable2
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multipler = int.Parse(Console.ReadLine());

            for (int i = multipler; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", num, i, num * i);

            }
            if (multipler > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", num, multipler, num * multipler);
            }
        }
    }
}
