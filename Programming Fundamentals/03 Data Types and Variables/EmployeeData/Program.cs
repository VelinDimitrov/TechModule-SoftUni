using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            long age = long.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long idNumber = long.Parse(Console.ReadLine());
            long employeeNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("First name: "+name);
            Console.WriteLine("Last name: "+lastName);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Personal ID: "+idNumber);
            Console.WriteLine("Unique Employee number: " + employeeNumber);
        }
    }
}
