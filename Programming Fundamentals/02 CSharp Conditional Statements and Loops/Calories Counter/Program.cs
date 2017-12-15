using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCals = 0;
            for (int i = 0; i < n; i++)
            {
                string nameOfIngredient = Console.ReadLine().ToLower();
                switch (nameOfIngredient)
                {
                    case "cheese":
                        totalCals += 500;
                        break;
                    case "tomato sauce":
                        totalCals += 150;
                        break;
                    case "salami":
                        totalCals += 600;
                        break;
                    case "pepper":
                        totalCals += 50;
                        break;
                }                
            }
            Console.WriteLine($"Total calories: {totalCals}");
        }
    }
}
