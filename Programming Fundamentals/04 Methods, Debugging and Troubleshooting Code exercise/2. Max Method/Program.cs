using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int max =GetMax(firstNum,secondNum);
            Console.WriteLine(max);
        }
        static int GetMax(int firstNum, int secondNum)
        {
            int max = firstNum;
            int thirdNum = int.Parse(Console.ReadLine());

            if (max<secondNum)
            {
                max = secondNum;
            }
            if (max<thirdNum)
            {
                max = thirdNum;
            }
            return max;
        }
    }
}
