using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNum = int.Parse(Console.ReadLine());
            int SecondNum = int.Parse(Console.ReadLine());
            int ThirdNum = int.Parse(Console.ReadLine());
            int FourthNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{FirstNum:d4} {SecondNum:d4} {ThirdNum:d4} {FourthNum:d4}");
        }
    }
}
