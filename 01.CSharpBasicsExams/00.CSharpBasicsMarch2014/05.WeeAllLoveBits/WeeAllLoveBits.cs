﻿using System;

namespace _05.WeeAllLoveBits
{
    class WeeAllLoveBits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int result = 0;
                while (num > 0)
                {
                    int lastBit = num & 1;
                    num = num >> 1;
                    result = result << 1;
                    result = result | lastBit;
                }
                Console.WriteLine(result);
            }
        }
    }
}
