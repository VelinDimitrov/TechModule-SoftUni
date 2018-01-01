using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long numbersToBeCHecked = long.Parse(Console.ReadLine());
            for (long i = 2; i <= numbersToBeCHecked; i++)
            {
                bool prime = true;
                for (long r = 2; r <= Math.Sqrt(i); r++)
                {
                    if (i%r==0)
                    {
                        prime = false;
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {prime}");
            }
        }
    }
}

