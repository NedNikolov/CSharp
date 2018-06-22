using System;

namespace _01.BookProblem
{
    class BookProblem
    {
        static void Main()
        {
            int pages = int.Parse(Console.ReadLine());
            int campDays = int.Parse(Console.ReadLine());
            int normal = int.Parse(Console.ReadLine());

            if (campDays == 30 || normal ==0)
            {
                Console.WriteLine("never");
                return;
            }
            int pagesMonth = (30 - campDays) * normal;
            int totalMonth = (int)Math.Ceiling((double)pages / pagesMonth);
            int years = totalMonth / 12;
            int months = totalMonth % 12;
            Console.WriteLine("{0} years {1} months", years, months);
        }
    }
}