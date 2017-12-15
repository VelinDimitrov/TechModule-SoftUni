using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());

            string PeshoAttack = "Roundhouse kick";
            string GoshoAttack = "Thunderous fist";
            int PeshoHealth = 100, counter = 0;
            int GoshoHealth = 100;
            for (int i = 1; ; i++)
            {
                counter++;
                if (i%2==1)
                {
                    GoshoHealth -= PeshoDamage;
                    if (GoshoHealth<=0)
                    {
                        Console.WriteLine($"Pesho won in {counter}th round.");
                       return;
                    }
                    Console.WriteLine($"Pesho used { PeshoAttack} and reduced Gosho to {GoshoHealth} health.");
                }
                else
                {
                    PeshoHealth -= GoshoDamage;
                    if (PeshoHealth <=0)
                    {
                        Console.WriteLine($"Gosho won in {counter}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used {GoshoAttack} and reduced Pesho to {PeshoHealth} health.");
                }
                if (i%3==0)
                {
                    PeshoHealth += 10;
                    GoshoHealth += 10;
                }
            }
        }
    }
}
