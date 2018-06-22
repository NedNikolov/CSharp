using System;

namespace _05.BPMCounter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            double beatsPerMinutes = int.Parse(Console.ReadLine());
            double numberOfBeats = int.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4.0;
            int seconds = (int)((numberOfBeats / beatsPerMinutes) * 60);
            int minutes = seconds / 60;
            seconds = seconds % 60;

            Console.WriteLine("{0} bars - {1}m {2}s", Math.Round(bars, 1), minutes, seconds);
        }
    }
}
