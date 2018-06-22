using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string symbol = (Console.ReadLine());
            if (symbol == "+" )
            {
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1 ,symbol , n2 , (n1 + n2), (n1 + n2) % 2 == 0 ? "even" : "odd");
            }
            else if (symbol == "-")
            {
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, symbol, n2, (n1 - n2), (n1 - n2) % 2 == 0 ? "even" : "odd");
            }       
	        else if (symbol == "*")
            {
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, symbol, n2, (n1 * n2), (n1 * n2) % 2 == 0 ? "even" : "odd");
            }
            else if (symbol == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero",n1);
                }
                else
                {
                    Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, ((double)n1 / n2));     
                }
                
            }
            else if (symbol == "%" )
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);  
                }
                else
                {
                    Console.WriteLine("{0} % {1} = {2}", n1, n2,(n1 % n2));    
                }
                
            }
           
        }
    }
}
