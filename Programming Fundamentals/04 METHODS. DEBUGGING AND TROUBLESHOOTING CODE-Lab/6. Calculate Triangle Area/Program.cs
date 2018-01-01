using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetAreaOfTriangle(width,height);
            Console.WriteLine(area);
        }

        static double GetAreaOfTriangle(double width, double height)
        {
            return width * height / 2;
        }
    }
}
