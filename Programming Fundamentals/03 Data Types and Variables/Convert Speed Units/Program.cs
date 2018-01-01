using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            long meters = long.Parse(Console.ReadLine());
            long hours = long.Parse(Console.ReadLine());
            long minutes = long.Parse(Console.ReadLine());
            long seconds = long.Parse(Console.ReadLine());
            float miles = meters / 1609.0f;
            float kilometers = meters/1000.0f;
            
            float convertedToSeconds =(hours*60.0f)+minutes;
            convertedToSeconds = convertedToSeconds * 60.0f + seconds;
            float metersPerSecond = meters / convertedToSeconds;
            Console.WriteLine($"{metersPerSecond:0.######}");
            float convertedPerHour = convertedToSeconds / 3600.0f;
            float kilometersPerHour = kilometers / convertedPerHour;
            Console.WriteLine($"{kilometersPerHour:0.######}");
            float milesPerHour = miles / convertedPerHour;
            Console.WriteLine($"{milesPerHour:0.######}");
        }
    }
}
