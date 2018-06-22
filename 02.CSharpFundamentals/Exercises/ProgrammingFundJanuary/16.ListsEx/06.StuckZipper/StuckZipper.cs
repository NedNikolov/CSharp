using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StuckZipper
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            var listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            var listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            var idealNumberDigit = CalculateIdealNumberOfDigits(listOne, listTwo);

            RemoveElements(listOne, idealNumberDigit);
            RemoveElements(listTwo, idealNumberDigit);

            var insertionIndex = 1;
            for (int i = 0; i < listOne.Count; i++)
            {
                var currElement = listOne[i];
                listTwo.Insert(Math.Min(insertionIndex, listTwo.Count), currElement);
                insertionIndex += 2;
            }
            Console.WriteLine(string.Join(" ", listTwo));
        }

        private static void RemoveElements(List<int> list, int idealNumberDigit)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var currentNumberOfDigits = NumberOfDigits(list[i]);
                if (currentNumberOfDigits > idealNumberDigit)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        private static int CalculateIdealNumberOfDigits(List<int> listOne, List<int> listTwo)
        {
            var idealNumberDigit = int.MaxValue;
            foreach (var item in listOne)
            {
                var numberOfDigits = NumberOfDigits(item);
                if (numberOfDigits < idealNumberDigit)
                {
                    idealNumberDigit = numberOfDigits;
                }
            }

            foreach (var item in listTwo)
            {
                var numberOfDigits = NumberOfDigits(item);
                if (numberOfDigits < idealNumberDigit)
                {
                    idealNumberDigit = numberOfDigits;
                }
            }

            return idealNumberDigit;
        }

        static int NumberOfDigits(int number)
        {
            number = Math.Abs(number);
            var numerOfDigits = 0;
            while (number > 0)
            {
                numerOfDigits++;
                number /= 10;
            }
            return numerOfDigits;

            //var numberOfDigits = number.ToString().Length;
        }
    }
}
