﻿using System;

namespace _03.SandGlass
{
    class SandGlass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int asterixes = n;
            int dots = 0;
            while (true)
            {
                //DrawLine(asterixes, dots);


                for (int i = 0; i < dots; i++)
                {
                    Console.Write('.');
                }
                for (int i = 0; i < asterixes; i++)
                {
                    Console.Write('*');
                }
                for (int i = 0; i < dots; i++)
                {
                    Console.Write('.');
                }


                asterixes = asterixes - 2;
                dots++;
                Console.WriteLine();
                if (asterixes == -1)
                {
                    break;
                }
            }

            asterixes = 3;
            dots = (n -asterixes)/2;
            while (true)
            {
                //DrawLine(asterixes, dots);

                for (int i = 0; i < dots; i++)
                {
                    Console.Write('.');
                }
                for (int i = 0; i < asterixes; i++)
                {
                    Console.Write('*');
                }
                for (int i = 0; i < dots; i++)
                {
                    Console.Write('.');
                }


                asterixes = asterixes + 2;
                dots--;
                Console.WriteLine();
                if (dots == -1)
                {
                    break;
                }
            }

        }
        //private static void DrawLine(int asterixes, int dots)
        //{
        //    for (int i = 0; i < dots; i++)
        //    {
        //        Console.Write('.');
        //    }
        //    for (int i = 0; i < asterixes; i++)
        //    {
        //        Console.Write('*');
        //    }
        //    for (int i = 0; i < dots; i++)
        //    {
        //        Console.Write('.');
        //    }
        //}
    }
}
