using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            
            byte century = byte.Parse(Console.ReadLine());
            short year = Convert.Tolong16(century * 100);
            long days = Convert.Tolong32(Math.Floor(year * 365.2422));
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long miliSeconds = seconds * 1000;
            ulong microSeconds =Convert.ToUlong64(miliSeconds*1000);
            decimal nanoSeconds = Convert.ToDecimal(microSeconds * 1000.0);
            Console.WriteLine($"{century} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");
        }
    }
}
