using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LightTorches
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            char space = ' ';
            char star = '*';


            Console.Write(new string(space, n / 2));           
            Console.Write(new string(star, 1));
            Console.Write(new string(star, n -1));
            Console.Write(new string(star, 1));
            Console.Write(new string(space, n / 2));
            Console.WriteLine();

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string(space, n / 2));
                Console.Write(new string(star, 1));
                Console.Write(new string(space, n - 1));
                Console.Write(new string(star, 1));
                Console.Write(new string(space, n / 2));
                Console.WriteLine();
            }
            int leftspace = n/2;
            int middlespace = n - 1;
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string(space, leftspace));
                Console.Write(new string(star, 1));
                Console.Write(new string(space, middlespace));
                Console.Write(new string(star, 1));
                Console.Write(new string(space, leftspace));
                Console.WriteLine();
                leftspace--;
                middlespace += 2;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(star, 1));
                Console.Write(new string('.', middlespace));
                Console.Write(new string(star, 1));
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(star, 1));
                Console.Write(new string('@', middlespace));
                Console.Write(new string(star, 1));
                Console.WriteLine();
            }

            Console.WriteLine(new string(star, middlespace + 2));
        }
    }
}
