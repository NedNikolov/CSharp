using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NoteStatistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {
            var letters = new List<string>()
                { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};

            var frequence = new List<double>()
                { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            var givenFrequences = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            var noteFrequence = new string[givenFrequences.Length];
            for (int count = 0; count < givenFrequences.Length; count++)
            {
                var currentFrequence = givenFrequences[count];
                var index = frequence.IndexOf(currentFrequence);
                noteFrequence[count] = letters[index];
            }

            var sumNaturals = 0.0;
            var sumSharps = 0.0;

            for (int count = 0; count < givenFrequences.Length; count++)
            {
                if (noteFrequence[count].Contains("#"))
                {
                    sumSharps += givenFrequences[count];
                }
                else
                {
                    sumNaturals += givenFrequences[count];
                }
            }
            Console.WriteLine($"Notes: {string.Join(" ", noteFrequence)}");
            Console.WriteLine($"Naturals: {string.Join(", ", noteFrequence.Where(x => !x.Contains("#")))}");
            Console.WriteLine($"Sharps: {string.Join(", ", noteFrequence.Where(x => x.Contains("#")))}");
            Console.WriteLine($"Naturals sum: {sumNaturals}");
            Console.WriteLine($"Sharps sum: {sumSharps}");
        }
    }
}
