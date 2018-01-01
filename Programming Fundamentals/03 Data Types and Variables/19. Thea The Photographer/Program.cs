using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long takenPics = long.Parse(Console.ReadLine());
            long secondsForFilter = long.Parse(Console.ReadLine());
            long filterFactorPercentage = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());
            double percentage = filterFactorPercentage / 100.0;
            double picturesAfterFilter = Math.Ceiling(takenPics * percentage);
            double timeForFilter = takenPics * secondsForFilter;
            double uploadPictureTime = timeForFilter + (picturesAfterFilter * uploadTime);

            long days = (long)uploadPictureTime / 86400;
            long hours = ((long)uploadPictureTime / 3600) % 24;
            long minutes = ((long)uploadPictureTime / 60) % 60;
            long seconds = (long)uploadPictureTime % 60;
            Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
