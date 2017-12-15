using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());
            int combinataions = 0;
            int sum = 0;
            for (int FirstNumber = N; FirstNumber >= 1; FirstNumber--)
            {
                for (int SecondNumber = 1; SecondNumber <= M; SecondNumber++)
                {
                    combinataions++;
                    
                    sum += 3 * (FirstNumber * SecondNumber);
                    if (sum >= maxNum)
                    {
                        Console.WriteLine($"{combinataions} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxNum}");
                        return;
                    }
                }
               
               
                
            }
            Console.WriteLine($"{combinataions} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
