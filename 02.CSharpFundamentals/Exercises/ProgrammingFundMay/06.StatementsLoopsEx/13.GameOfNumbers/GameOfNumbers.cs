using System;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int magicA = 0;
            int magicB = 0;
            bool isMagic = false;
            int counter = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    counter++;
                    if (i + j == magicNum)
                    {
                        magicA = i;
                        magicB = j;
                        isMagic = true;
                    }
                }
            }
            if (isMagic == false)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNum);
            }
            else
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", magicA, magicB, magicA + magicB);
            }
            
        }
    }
}
