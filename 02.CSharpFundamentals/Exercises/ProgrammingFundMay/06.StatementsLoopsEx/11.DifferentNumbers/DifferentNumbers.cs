using System;

namespace _11.DifferentNumbers
{
    class DifferentNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int firstDigit = a; firstDigit <= b; firstDigit++)
            {
                for (int secondDigit = a; secondDigit <= b; secondDigit++)
                {
                    for (int thirdDigit = a; thirdDigit <= b; thirdDigit++)
                    {
                        for (int fourthDigit = a; fourthDigit <= b; fourthDigit++)
                        {
                            for (int fifthDigit = a; fifthDigit <= b; fifthDigit++)
                            {
                                if (firstDigit < secondDigit && secondDigit < thirdDigit && thirdDigit < fourthDigit && fourthDigit < fifthDigit)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4}", firstDigit, secondDigit, thirdDigit, fourthDigit, fifthDigit);
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
