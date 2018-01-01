using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonachiNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonachi(fibonachiNumber));
        }

        static int Fibonachi(int number)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < number; i++)
            {
                int temp = a;
                a = b;
                b = b + temp;
            }
            return b;
        }
    }
}
