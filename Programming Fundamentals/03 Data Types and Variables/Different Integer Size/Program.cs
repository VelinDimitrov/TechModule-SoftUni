using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_longeger_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            try
            {
                long a = Convert.Tolong64(number);
                Console.WriteLine($"{a} can fit in:");
                if (a>=sbyte.MinValue&&a<=sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (a >= byte.MinValue && a <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (a >= short.MinValue && a <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (a >= ushort.MinValue && a <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (a >= long.MinValue && a <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
                if (a >= ulong.MinValue && a <= ulong.MaxValue)
                {
                    Console.WriteLine("* ulong");
                }
                if (a >= long.MinValue && a <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }

            }
            catch (Exception)
            {
                Console.WriteLine($"{number} can't fit in any type");
                
            }
            
        }
    }
}
