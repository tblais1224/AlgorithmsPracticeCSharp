using System;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsPractice
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var primes = new PrimeNumbers(977);
            primes.GetPrimes();
            Console.WriteLine(primes.SumPrimes());
        }
    }
}