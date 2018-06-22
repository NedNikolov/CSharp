using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.BookOrder
{
    class BookOrder
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            int n = int.Parse(Console.ReadLine());
            double finalSum = 0;
            double discount = 0;
            int allBooks = 0;
            int sumBooks = 0;
            double sumPrice = 0;

            for (int i = 0; i < n; i++)
            {
                    int packets = int.Parse(Console.ReadLine());
                    int books = int.Parse(Console.ReadLine());
                    double price = double.Parse(Console.ReadLine());

                    allBooks = packets * books;
                    

                    if ((packets > 0) && (packets < 10))
                    {
                        discount = 1;
                    }
                    else if ((packets > 9) && (packets < 20))
                    {
                        discount = 0.95;
                    }
                    else if ((packets > 19) && (packets < 30))
                    {
                        discount = 0.94;
                    }
                    else if ((packets > 29) && (packets < 40))
                    {
                        discount = 0.93;
                    }
                    else if ((packets > 39) && (packets < 50))
                    {
                        discount = 0.92;
                    }
                    else if ((packets > 49) && (packets < 60))
                    {
                        discount = 0.91;
                    }
                    else if ((packets > 59) && (packets < 70))
                    {
                        discount = 0.90;
                    }
                    else if ((packets > 69) && (packets < 80))
                    {
                        discount = 0.89;
                    }
                    else if ((packets > 79) && (packets < 90))
                    {
                        discount = 0.88;
                    }
                    else if ((packets > 89) && (packets < 100))
                    {
                        discount = 0.87;
                    }
                    else if ((packets > 99) && (packets < 110))
                    {
                        discount = 0.86;
                    }
                    else if (packets > 109)
                    {
                        discount = 0.85;
                    }

                    finalSum = (double) allBooks * (price * discount);
                    sumBooks = sumBooks + allBooks;
                    sumPrice = sumPrice + finalSum;

                
            }
            Console.WriteLine(sumBooks);
                Console.WriteLine("{0:F2}",sumPrice);
            
        }
    }
}
