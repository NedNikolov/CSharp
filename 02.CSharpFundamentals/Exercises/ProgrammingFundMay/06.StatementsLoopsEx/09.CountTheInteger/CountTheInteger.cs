using System;

namespace _09.CountTheInteger
{
    class CountTheInteger
    {
        static void Main(string[] args)
        {

            int numberInt = 0;
            try
            {
                while (true)
                {
                    var input = int.Parse(Console.ReadLine());
                    numberInt++;
                }

            }
            catch (Exception)
            {
                Console.WriteLine(numberInt);
            }

        }
    }
}
