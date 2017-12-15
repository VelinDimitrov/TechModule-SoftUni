using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 50.0, doubleroom = 65.0, suite = 75.0;
            
            if (nights>7)
            {
                studio *=  0.95;
            }
            switch (month)
            {
                case "June":
                case "September":
                    studio = 60.0;
                    doubleroom = 72.0;
                    suite = 82.0;
                    if (nights>14)
                    {
                        doubleroom =doubleroom* 0.90;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studio = 68.0;
                    doubleroom = 77.0;
                    suite = 89.0;
                    if (nights>14)
                    {
                        suite = suite* 0.85;
                    }
                    break;                
            }
            double sumStudio = studio*nights;
            double sumDouble = doubleroom * nights;
            double sumSuite = suite * nights;
            if (nights>7&&(month=="September"||month=="October"))
            {
                sumStudio = sumStudio - studio;
            }
            Console.WriteLine($"Studio: {sumStudio:f2} lv.");
            Console.WriteLine($"Double: {sumDouble:f2} lv.");
            Console.WriteLine($"Suite: {sumSuite:f2} lv.");
        }
    }
}
