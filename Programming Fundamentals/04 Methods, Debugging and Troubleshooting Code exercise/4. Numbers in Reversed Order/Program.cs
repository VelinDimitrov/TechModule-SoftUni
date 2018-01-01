using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberToReverse = decimal.Parse(Console.ReadLine());
            PrintRevurseNumber(numberToReverse);
        }

        static void PrintRevurseNumber(decimal numberToReverse)
        {
            string RevurseString = Convert.ToString(numberToReverse);
            char[] reverse = RevurseString.ToCharArray();
            for (int i = reverse.Length-1; i >=0; i--)
            {
                Console.Write(reverse[i]);
            }
            Console.WriteLine();
        }
    }
}
