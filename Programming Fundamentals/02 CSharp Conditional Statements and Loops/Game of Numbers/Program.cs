using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int a = 0, b = 0, combinations = 0; ;
            for (int i = N; i <= M; i++)
            {
                for (int r = N; r <= M; r++)
                {
                    if (i+r==magicalNumber)
                    {
                        a = i;
                        b = r;                        
                    }
                    combinations++;
                }
            }
            if (a!=0)
            {
                Console.WriteLine($"Number found! {a} + {b} = {magicalNumber}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");
            }
        }
    }
}
