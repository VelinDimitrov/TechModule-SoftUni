using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            PrintSquare(size);
        }

        static void PrintSquare(int size)
        {
            PrintHeaderAndFooter(size*2);
            PrintMiddleRows(size-2);
            PrintHeaderAndFooter(size*2);
        }

        static void PrintMiddleRows(int numberOfRows)
        {
            
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.Write('-');
                for (int r = 0; r <= numberOfRows; r++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
           
        }

        static void PrintHeaderAndFooter(int numberOfMiddlePipes)
        {
            Console.WriteLine(new string('-',numberOfMiddlePipes));
        }
    }
}
