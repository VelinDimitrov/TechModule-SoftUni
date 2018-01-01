using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberToBeChecked = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(numberToBeChecked));
        }
        static bool IsPrime(long numberToBeChecked)
        {
            if (numberToBeChecked<2)
            {
                return false;
            }
            for (long i = 2; i <= Math.Sqrt(numberToBeChecked); i++)
            {
                if (numberToBeChecked%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
