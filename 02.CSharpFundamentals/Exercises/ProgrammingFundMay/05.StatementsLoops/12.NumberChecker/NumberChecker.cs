using System;

namespace _12.NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {

            try
            {
                var n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
