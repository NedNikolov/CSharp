﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FoldSum
{
    class FoldSum
    {
        static void Main(string[] args)
        {
            int[] initialNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = initialNumbers.Length / 4;
            List<int> leftPart = initialNumbers.Take(k).Reverse().ToList();
            List<int> rightPart = initialNumbers.Reverse().Take(k).ToList();

            int[] downArr = initialNumbers.Skip(k).Take(2 * k).ToArray();
            int[] upperPart = leftPart.Concat(rightPart).ToArray();

            for (int i = 0; i < downArr.Length; i++)
            {
                downArr[i] += upperPart[i];
            }

            Console.WriteLine(string.Join(" ", downArr));
        }
    }
}
 