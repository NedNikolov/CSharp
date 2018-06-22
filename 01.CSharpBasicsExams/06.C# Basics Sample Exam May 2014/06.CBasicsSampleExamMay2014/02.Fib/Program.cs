using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fib
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNum = BigInteger.Parse(Console.ReadLine());
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger sum = 0;

            for (int i = 3; i < n; i++)
            {
                sum = firstNum + secondNum + thirdNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = sum;


            }
            Console.WriteLine(thirdNum);
        }
    }
}
