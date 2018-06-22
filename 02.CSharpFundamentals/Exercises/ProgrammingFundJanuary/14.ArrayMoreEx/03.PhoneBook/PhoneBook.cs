using System;
using System.Linq;

namespace _03.PhoneBook
{
    class PhoneBook
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();

            string name = Console.ReadLine();
            while (name != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        Console.WriteLine("{0} -> {1}", names[i], numbers[i]);
                    }
                }
                name = Console.ReadLine();
            }
        }
    }
}
