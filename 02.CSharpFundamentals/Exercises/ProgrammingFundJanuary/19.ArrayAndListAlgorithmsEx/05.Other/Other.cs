using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Other
{
    class Other
    {
        static void Main(string[] args)
        {
            var frequence = Console.ReadLine().Split(new char[] { '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var leftHalf = ParseLeftSide(frequence, 0);
            var rightHalf = ParseRightSide(frequence, 1);
            var parsedFrequence = string.Empty;
            Console.WriteLine(leftHalf + rightHalf);
        }

        private static string ParseLeftSide(string[] frequence, int start)
        {
            var newIndex = 0;
            var currentString = string.Empty;
            for (int index = start; index < frequence.Length; index += 2)
            {
                if (frequence[index] != "0")
                {
                    var asciiCode = Convert.ToInt16(frequence[index]);
                    currentString += (char)asciiCode;
                    newIndex++;
                }
            }
            return currentString;
        }

        private static string ParseRightSide(string[] frequence, int start)
        {
            var newIndex = frequence.Length - 1;
            var currentString = string.Empty;
            for (int index = start; index < frequence.Length; index += 2)
            {
                if (frequence[index] != "0")
                {
                    var asciiCode = Convert.ToInt16(frequence[index]);
                    currentString = (char)asciiCode + currentString;
                    newIndex--;
                }
            }
            return currentString;
        }

    }
}
