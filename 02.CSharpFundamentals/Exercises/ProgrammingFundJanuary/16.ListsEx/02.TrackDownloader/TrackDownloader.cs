using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var blackList = Console.ReadLine().Split();
            var downloadedTracks = new List<string>();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var isInBlackList = false;
                foreach (var blackListedSong in blackList)
                {
                    if (line.Contains(blackListedSong))
                    {
                        isInBlackList = true;
                        break;  
                    }   
                }

                if (!isInBlackList)
                {
                    downloadedTracks.Add(line);
                }
                line = Console.ReadLine();
            }

            downloadedTracks.Sort();

            foreach (var track in downloadedTracks)
            {
                Console.WriteLine(track);
            }
        }
    }
}
