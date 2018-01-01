using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double diffrence = Math.Abs(a-b);
            bool equal = true;
            if (diffrence> 0.000001)
            {
                equal = false;
            }
            Console.WriteLine(equal);
        }
    }
}
