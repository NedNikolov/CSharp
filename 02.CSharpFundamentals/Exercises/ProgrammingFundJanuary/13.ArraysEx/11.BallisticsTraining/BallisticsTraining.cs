using System;
using System.Linq;

namespace _11.BallisticsTraining
{
    class BallisticsTraining
    {
        static void Main(string[] args)
        {
            int[] targetXY = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] givenTargetXY = Console.ReadLine().Split(' ').ToArray();
            int targetY = 0;
            int targetX = 0;

            for (int i = 0; i < givenTargetXY.Length - 1; i+=2)
            {
                if (givenTargetXY[i].Contains("left"))
                {
                    targetX -= int.Parse(givenTargetXY[i + 1]);
                }
                else if (givenTargetXY[i].Contains("right"))
                {
                    targetX += int.Parse(givenTargetXY[i + 1]);
                }
                else if (givenTargetXY[i].Contains("up"))
                {
                    targetY += int.Parse(givenTargetXY[i + 1]);
                }
                else
                {
                    targetY -= int.Parse(givenTargetXY[i + 1]);
                }
            }

            
            if (targetXY[0] == targetX && targetXY[1] == targetY)
            {
                Console.WriteLine("firing at [{0}, {1}]", targetX, targetY);
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("firing at [{0}, {1}]", targetX, targetY);
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
