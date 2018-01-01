using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPrimeNumbers = int.Parse(Console.ReadLine());
            int endPrimeNumbers = int.Parse(Console.ReadLine());
            PrintPrime(startPrimeNumbers,endPrimeNumbers);
        }

        static void PrintPrime(int startPrimeNumbers, int endPrimeNumbers)
        {
            string PrimeResult = String.Empty;
            if (startPrimeNumbers<2) //if the number is less than 2 because 0 and 1 will always returns prime
            {
                startPrimeNumbers = 2;
            }
            for (int i = startPrimeNumbers; i <= endPrimeNumbers; i++) //check all numbers in theinterval
            {
                if (startPrimeNumbers<2)
                {
                    startPrimeNumbers = 2;
                }
                bool isPrime = CheckPrime(i); //func to check prime
                if (isPrime) //adding to the string if found
                {
                    PrimeResult +=i+", ";
                }
            }
            try //if the start number is bigger then we catch exception
            {
                PrimeResult = PrimeResult.Remove(PrimeResult.Length - 2);
                Console.WriteLine(PrimeResult);
            }
            catch (Exception)
            {

                
            }
            
            
        }
        static bool CheckPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
