using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magical_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char SecondChar = char.Parse(Console.ReadLine());
            char NotPrintedChar = char.Parse(Console.ReadLine());
            for (char i = firstChar; i <= SecondChar; i++)
            {
                for (char r = firstChar; r <= SecondChar; r++)
                {
                    for (char u = firstChar; u <= SecondChar; u++)
                    {
                        string combination =i.ToString()+r.ToString()+u.ToString() ;
                        if (combination.Contains(NotPrintedChar))
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write(combination +" ");
                        }
                    }
                }
            }
        }
    }
}
