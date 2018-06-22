using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            long verticalStart = long.Parse(Console.ReadLine());
            long horizontalStart = long.Parse(Console.ReadLine());


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    long curValue = (verticalStart + i) * (horizontalStart + j);
                    Console.Write(curValue + " ");
                }
                Console.WriteLine();
            }



        }



        
    }
}
