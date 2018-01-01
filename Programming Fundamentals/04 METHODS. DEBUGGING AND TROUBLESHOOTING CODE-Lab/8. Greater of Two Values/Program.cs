using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type=="int")
            {
                int firstInt = int.Parse(Console.ReadLine());
                int secondInt = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInt, secondInt));
            }
            else if (type=="string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                Console.WriteLine(GetMax(firstString, secondString));
            }
            else if (type=="char")
            {
                char firstChar= char.Parse(Console.ReadLine());
                char SecondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstChar, SecondChar));
            }
           
        }

        static string GetMax(string firstString, string secondString)
        {
            if (String.Compare(firstString,secondString)>0)
            {
                return firstString;
            }
            else if (String.Compare(firstString, secondString)==0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        static char GetMax(char firstCh, char secondCh)
        {
            if (firstCh > secondCh)
            {
                return firstCh;
            }
            else
            {
                return secondCh;
            }
        }
        static int GetMax(int firstInt, int secondInt)
        {
            if (firstInt>secondInt)
            {
                return firstInt;
            }
            else
            {
                return secondInt;
            }
        }
    }
}
