using System;

namespace _04.PhotoGalery
{
    class PhotoGalery
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int bytes = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double size = 0;
            string bytesName = "";

            if (bytes < 1000)
            {
                size = bytes;
                bytesName = "B";
            }
            else if (bytes < 1000 * 1000)
            {
                size = bytes / 1000.0;
                bytesName = "KB";
            }
            else if (bytes < 1000 * 1000 * 1000)
            {
                size = bytes / (1000 * 1000.0);
                bytesName = "MB";
            }

            string resolutionType = "";
            if (width > height)
            {
                resolutionType = "landscape";
            }
            else if (width < height)
            {
                resolutionType = "portrait";
            }
            else
            {
                resolutionType = "square";
            }

            Console.WriteLine("Name: DSC_{0:D4}.jpg", photoNumber);
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2} {3:d2}:{4:d2}",day, month, year, hour, minutes);
            Console.WriteLine("Size: {0}{1}", size, bytesName);
            Console.WriteLine("Resolution: {0}x{1} ({2})", width, height, resolutionType);
        }
    }
}
