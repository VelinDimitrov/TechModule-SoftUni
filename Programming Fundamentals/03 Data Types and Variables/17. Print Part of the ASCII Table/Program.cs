using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Prlong_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());
            for (long i = firstNum; i <= secondNum; i++)
            {
                Console.Write((char)(i)+" ");
            }
        }
    }
}
