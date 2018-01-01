using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double temperature = ConvertFahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{temperature:f2}");
        }

        static double ConvertFahrenheitToCelsius(double fahrenheit)
        { 

            double temperature =( fahrenheit-32)*5/9;
            return temperature;
        }
    }
}
