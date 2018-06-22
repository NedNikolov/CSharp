using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine()); 
            var pricePerMeter = double.Parse(Console.ReadLine()); 
            var secondRoom = smallRoom + (smallRoom * 0.1);
            var thirdRoom = secondRoom + (secondRoom * 0.1);
            var bath = smallRoom / 2 ;
            var area = smallRoom + kitchen + secondRoom + thirdRoom + bath;
            var allArea = area + (area * 0.05);
            var price = allArea * pricePerMeter;
            
            Console.WriteLine("{0:f2}",price);
            
        }
    }
}
