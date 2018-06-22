using System;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempts = int.Parse(Console.ReadLine());
            int slapped = 0;
            int slappedSum = 0;
            int escaped = 0;
            int bottleSum = 0;
            int escapedSum = 0;
            for (int i = 0; i < attempts; i++)
            {
                int escAtt = int.Parse(Console.ReadLine());
                escaped = escAtt - 5;
                int beer = int.Parse(Console.ReadLine());
                if (escaped < 0)
                {
                    escaped = 0;
                }
                bottleSum = bottleSum + beer;
                escapedSum = escapedSum + escaped;
                if (escAtt >=5)
                {
                    slapped = 5; 
                }
                else
                {
                    slapped = escAtt;
                }
                slappedSum = slappedSum + slapped;

            }
            int bottleFinal = 0;
            int bottleFinal2 = 0;
            if (bottleSum >= 6)
            {
                bottleFinal = bottleSum%6;
                bottleFinal2 = bottleSum/6;
            }
            else
            {
                bottleFinal = bottleSum;
            }

            Console.WriteLine("{0} thieves slapped.", slappedSum);
            Console.WriteLine("{0} thieves escaped.", escapedSum );
            Console.WriteLine("{0} packs, {1} bottles.", bottleFinal2, bottleFinal);
        }
    }
}

  