using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTriangle = int.Parse(Console.ReadLine());
            Printing_Triangle(sizeOfTriangle);
        }

        static void Printing_Triangle(int sizeOfTriangle)
        {
            PrintTopPart(sizeOfTriangle);
            PrintBottomPart(sizeOfTriangle);
        }

        static void PrintBottomPart(int size)
        {
            for (int i = size-1; i >=1 ; i--)
            {
                PrintLine(i);
            }
            
        }

        static void PrintTopPart(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int numberToWhereToBePriented)
        {
            for (int i = 1; i <= numberToWhereToBePriented; i++)
            {
                Console.Write($"{i} ");
                if (numberToWhereToBePriented<i+1)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
