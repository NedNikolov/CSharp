using System;

class Program
{
    static void Main()
    {
        double p = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());
        double loan = double.Parse(Console.ReadLine());
        double frloan = double.Parse(Console.ReadLine());
        double realLoan = 1 + loan;
        double numn = Math.Pow(realLoan, n);
        double bankLoan = p*numn;
        double friendLoan = p*(1 + frloan);

        if (bankLoan < friendLoan)
        {
            Console.WriteLine("{0:0.00} Bank", bankLoan);
        }
        else if (bankLoan > friendLoan)
        {
            Console.WriteLine("{0:0.00} Friend", friendLoan);
        }
        else
        {
            Console.WriteLine(friendLoan); 
        }
        
    }

}
