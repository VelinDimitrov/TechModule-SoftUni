using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double firstDistance = Distance(x1,y1);
            double secondDistance = Distance(x2,y2);
            string format = "({0}, {1})";
            if (firstDistance<=secondDistance)
            {
                Console.WriteLine(format,x1,y1);
            }
            else
            {
                Console.WriteLine(format, x2, y2);
            }
        }

        static double Distance(double num1, double num2)
        {
            return Math.Sqrt(Math.Pow(num1, 2)) + Math.Sqrt(Math.Pow(num2, 2));
        }
    }
}
