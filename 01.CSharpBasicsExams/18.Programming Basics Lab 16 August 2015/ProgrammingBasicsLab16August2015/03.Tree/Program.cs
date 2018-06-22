using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char dot = '\'';
            char tree = '^';
            char stable = '|';
            char bottom = '-';
            char space = ' ';
            int firstDots = size;
            int middle = 1;
            


                for (int j = 0; j < size/2+1; j++)
                {
                    Console.Write(new string(dot, firstDots));
                    Console.Write(new string(tree, middle));
                    Console.Write(new string(dot, firstDots));
                    Console.WriteLine();
                    firstDots--;
                    middle += 2;
                }
                firstDots = size;
                middle = 1;
                for (int j = 0; j < size / 2 + 1; j++)
                {
                    firstDots--;
                    middle += 2;
                    Console.Write(new string(dot, firstDots));
                    Console.Write(new string(tree, middle));
                    Console.Write(new string(dot, firstDots));
                    Console.WriteLine();
                    
                }
            
            for (int i = 0; i < size/2+1; i++)
            {
                Console.Write(new string(dot, size - 1));
                Console.Write(new string(stable, 1));
                Console.Write(new string(space, 1));
                Console.Write(new string(stable,  1));
                Console.Write(new string(dot, size - 1));
                Console.WriteLine();
            }
            Console.WriteLine(new string(bottom, size*2+1));
        }
    }
}
