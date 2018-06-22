using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Magic_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int firstDigit = 0; firstDigit <= 9; firstDigit++)
            {
                for (int secondDigit = 0; secondDigit <= 9; secondDigit++)
                {
                    for (int thirdDigit = 0; thirdDigit <= 9; thirdDigit++)
                    {
                        for (int fourthDigit = 0; fourthDigit <= 9; fourthDigit++)
                        {
                            for (int fifthDigit = 0; fifthDigit <= 9; fifthDigit++)
                            {
                                for (int sixtDigit = 0; sixtDigit <= 9; sixtDigit++)
                                {
                                    if (firstDigit * secondDigit * thirdDigit * fourthDigit * fifthDigit * sixtDigit == n )
                                    {
                                        Console.Write("" + firstDigit + secondDigit + thirdDigit + fourthDigit + fifthDigit + sixtDigit + " ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
