using System;
using System.Text;

namespace _01.BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PrintRecieptHeader();
            PrintRecieptBody();
            PRintRecieptFooter();
        }

        static void PrintRecieptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintRecieptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PRintRecieptFooter()
        {
            char symbol = '\u00A9';
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
