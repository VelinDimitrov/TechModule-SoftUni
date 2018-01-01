using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());
            char thirdCh = char.Parse(Console.ReadLine());           
            Console.WriteLine(Convert.ToString(thirdCh) + Convert.ToString(secondCh) + Convert.ToString(firstCh));
        }
    }
}
