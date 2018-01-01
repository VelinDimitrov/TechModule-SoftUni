using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char chFromUser = char.Parse(Console.ReadLine());
            if (chFromUser>='0'&&chFromUser<='9')
            {
                Console.WriteLine("digit");
            }
            else if (chFromUser=='a'|| chFromUser == 'e' || chFromUser == 'i' || chFromUser == 'o' || chFromUser == 'u' )
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
            
        }
    }
}
