using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberToBePowered = double.Parse(Console.ReadLine());
            double poweNumber = double.Parse(Console.ReadLine());
            double result = PoweNumber(numberToBePowered,poweNumber);
            Console.WriteLine(result);
        }

        static double PoweNumber(double numberToBePowered, double poweNumber)
        {
            double result = 1;
            for (double i = 0; i < poweNumber; i++)
            {
                result *= numberToBePowered;
            }
            return result;
        }
    }
}
