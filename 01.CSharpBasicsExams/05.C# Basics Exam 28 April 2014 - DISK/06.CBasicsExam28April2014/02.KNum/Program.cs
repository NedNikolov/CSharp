using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());

            inputLine = inputLine + " " + int.MaxValue;
            string[] inputTokens = inputLine.Split(' ');
            int equalCount = 1;
            int prev = int.Parse(inputTokens[0]);
            for (int i = 1; i < inputTokens.Length; i++)
            {
                int num = int.Parse(inputTokens[i]);
                if (num == prev)
                {
                    equalCount++;
                }
                else
                {
                    // Print (count % k) times the number num
                    for (int counter = 0; counter < equalCount % k; counter++)
                    {
                        Console.Write(prev + " ");
                    }
                    equalCount = 1;
                }
                prev = num;
            }

        }
    }
}
