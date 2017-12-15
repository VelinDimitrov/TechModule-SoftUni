using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: "+'|'+new string('|',currentHealth));
            Console.WriteLine(new string('.', maximumHealth - currentHealth)+'|');
            Console.Write("Energy: " + '|' + new string('|', currentEnergy));
            Console.WriteLine(new string('.', maximumEnergy - currentEnergy) + '|');
        }
    }
}
