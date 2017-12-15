using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            string drink;
            double price;
            switch (profession)
            {
                case "Athlete":
                    drink="Water";
                    price = 0.70;
                    break;
                case "Businessman":                    
                    drink = "Coffee";
                    price = 1.00;
                    break;
                case "Businesswoman":
                    price = 1.00;
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    price = 1.70;
                    drink = "Beer";
                    break;
                default:                   
                    drink = "Tea";
                    price = 1.20;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {quantity*price:f2}.");

        }
    }
}
