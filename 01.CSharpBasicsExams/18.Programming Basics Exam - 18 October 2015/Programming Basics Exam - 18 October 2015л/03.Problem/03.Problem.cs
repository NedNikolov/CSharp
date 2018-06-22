using System;
using System.Globalization;
using System.Threading;


namespace _03.Problem
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            int albumEu = int.Parse(Console.ReadLine());
            decimal priseEu = decimal.Parse(Console.ReadLine());
            int albumNa = int.Parse(Console.ReadLine());
            decimal priseNa = decimal.Parse(Console.ReadLine());
            int albumSa = int.Parse(Console.ReadLine());
            decimal priseSa = decimal.Parse(Console.ReadLine());
            int concertCount = int.Parse(Console.ReadLine());
            decimal concertPrice = decimal.Parse(Console.ReadLine());

            decimal sumEu = (albumEu * priseEu)*1.94m;
            decimal sumNa = (albumNa * priseNa) * 1.72m;
            decimal sumSa = (albumSa * priseSa) / 332.74m;
            decimal allAlbums = sumEu + sumNa + sumSa;
            decimal producerSum = allAlbums - (allAlbums * 0.35m);
            decimal taxesSum = producerSum - (producerSum*0.20m);
            decimal concertSum = (concertCount*concertPrice) * 1.94m;
            if (concertSum >= 100000)
            {
                concertSum = concertSum - (concertSum*0.15m);
            }

            if(taxesSum > concertSum)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", taxesSum);
            }

            if (taxesSum <= concertSum)
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", concertSum);
            }
        }
    }
}
