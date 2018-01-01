using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetEvenAndOddMultiplying(Math.Abs(n)));

        }

        static int GetEvenAndOddMultiplying(int n)
        {
            
            return GetEven(n)*GetOdd(n);
        }

        static int GetEven(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit%2==0)
                {
                    sum += lastDigit;
                }
                n /= 10;               
            }
            return sum;
        }
        static int GetOdd(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 1)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
