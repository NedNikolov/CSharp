using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.WatermelonsAndMelons
{
    class Melons
    {
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int watermelon = 0;
            int melon = 0;
            int watermelonSum = 0;
            int melonSum = 0;

            

            for (int i = s; i < s+d; i++)
            {
                    switch (i % 7)
                    {

                        case 1:
                            watermelon = 1;
                            melon = 0;
                            break;
                        case 2:
                            watermelon = 0;
                            melon = 2;
                            break;
                        case 3:
                            watermelon = 1;
                            melon = 1;
                            break;
                        case 4:
                            watermelon = 2;
                            melon = 0;
                            break;
                        case 5:
                            watermelon = 2;
                            melon = 2;
                            break;
                        case 6:
                            watermelon = 1;
                            melon = 2;
                            break;
                        default:
                            break;
                    }

                
                watermelonSum = watermelonSum + watermelon;
                melonSum = melonSum + melon;
                watermelon = 0;
                melon = 0;

            }

            if (watermelonSum > melonSum)
            {
                Console.WriteLine("{0} more watermelons", watermelonSum - melonSum);
            }
            else if (watermelonSum < melonSum)
            {
                Console.WriteLine("{0} more melons",melonSum - watermelonSum);
            }
            else if (watermelonSum == melonSum)
            {
                Console.WriteLine("Equal amount: {0}", watermelonSum);
            }
        }
    }
}
