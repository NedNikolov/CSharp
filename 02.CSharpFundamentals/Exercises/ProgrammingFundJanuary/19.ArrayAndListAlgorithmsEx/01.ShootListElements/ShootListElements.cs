using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShootListElements
{
    class ShootListElements
    {
        static void Main(string[] args)
        {

            var isBanged = false;
            var shotedNumber = 0;
            var averageSumNumbers = 0.0;
            var currentElements = new List<int>();
            var action = Console.ReadLine();

            while (true)
            {
                var number = 0;
                if (int.TryParse(action, out number))
                {
                    currentElements = AddElementAtFront(currentElements, number);
                }

                if (action == "bang" && currentElements.Count > 0)
                {
                    isBanged = true;
                    averageSumNumbers = AverageSumNumber(currentElements);
                    currentElements = ShootFirstLeftSmallerElement(currentElements, averageSumNumbers, ref shotedNumber);
                    Console.WriteLine("shot {0}", shotedNumber);
                }
                else if (action == "bang" && currentElements.Count == 0)
                {
                    Console.WriteLine("nobody left to shoot! last one was {0}", shotedNumber);
                    return;
                }

                if (isBanged)
                {
                    currentElements = DecreasingAllElements(currentElements);
                }

                action = Console.ReadLine();

                if (action == "stop" && currentElements.Count == 0)
                {
                    Console.WriteLine("you shot them all. last one was {0}", shotedNumber);
                    return;
                }

                if (action == "stop" && currentElements.Count > 0)
                {
                    Console.WriteLine($"survivors: {string.Join(" ", currentElements)}");
                    return;
                }
            }

        }

        static List<int> DecreasingAllElements(List<int> currentElements)
        {
            for (int index = 0; index < currentElements.Count; index++)
            {
                currentElements[index]--;
            }
            return currentElements;
        }

        static List<int> ShootFirstLeftSmallerElement(List<int> currentElements, double averageSumNumbers, ref int shotedNumber)
        {
            var isFound = false;
            var temporaryList = new List<int>();
            for (int index = 0; index < currentElements.Count; index++)
            {
                if (currentElements[index] <= averageSumNumbers && !isFound)
                {
                    isFound = true;
                    shotedNumber = currentElements[index];
                    continue;
                }
                temporaryList.Add(currentElements[index]);
            }
            return temporaryList;
        }

        static double AverageSumNumber(List<int> currentElements)
        {
            var average = 0.0;
            for (int index = 0; index < currentElements.Count; index++)
            {
                average += currentElements[index];
            }
            return average /= (double) currentElements.Count;
        }

        static List<int> AddElementAtFront(List<int> currentElements, int number)
        {
            var temporaryList = new List<int>();
            temporaryList.Add(number);
            for (int index = 0; index < currentElements.Count; index++)
            {
                temporaryList.Add(currentElements[index]);
            }
            return temporaryList;
        }
    }
}
