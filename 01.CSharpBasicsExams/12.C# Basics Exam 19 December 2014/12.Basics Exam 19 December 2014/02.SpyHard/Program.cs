using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SpyHard
{
    class Program
    {
        static void Main(string[] args)
        {
            int system = int.Parse(Console.ReadLine());
            string message = Console.ReadLine();

            int totalValue = 0;
            string convertedValue = "";

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] >= 'A' && message[i] <= 'Z')
                {
                    totalValue += message[i] - 64;
                }
                else if (message[i] >= 'a' && message[i] <= 'z')
                {
                    totalValue += message[i] - 96;
                }
                else
                {
                    totalValue = message[i];
                }
            }

            do
            {
                convertedValue += (totalValue%system) + convertedValue;
                totalValue /= system;
            } while (totalValue != 0);
            Console.WriteLine(system.ToString() + message.Length + convertedValue);
        }
    }
}
