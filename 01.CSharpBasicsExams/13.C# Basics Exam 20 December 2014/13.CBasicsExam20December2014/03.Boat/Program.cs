using System;

namespace _03.Boat
{
    class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char star = '*';
            int sizeDot = n - 1;
            int sizeStar = 1;


            for (int i = 0; i < n; i++)
            {
                if (i < n/2)
                {
                    Console.Write(new string(dot, sizeDot));
                    Console.Write(new string(star, sizeStar));
                    Console.Write(new string(dot, n));
                    Console.WriteLine();
                    sizeStar += 2;
                    sizeDot -= 2;
                }
                else
                {
                    Console.Write(new string(dot, sizeDot));
                    Console.Write(new string(star, sizeStar));
                    Console.Write(new string(dot, n));
                    Console.WriteLine();
                    sizeStar -= 2;
                    sizeDot += 2;
                }
            }

            int nullDots = 0;
            int stars = n * 2;
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string(dot, nullDots));
                Console.Write(new string(star, stars));
                Console.Write(new string(dot, nullDots));
                Console.WriteLine();
                stars -= 2;
                nullDots++;
            }
            


        }
    }
}
