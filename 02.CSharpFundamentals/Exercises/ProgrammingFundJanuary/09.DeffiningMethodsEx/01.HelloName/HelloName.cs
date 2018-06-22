using System;

namespace _01.HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Name(name);
        }

        static void Name(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
    }
}
