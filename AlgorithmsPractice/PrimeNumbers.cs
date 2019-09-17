using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    public class PrimeNumbers
    {
        public int MaxPrimeNumber { get; set; }
        private readonly List<int> _primeNumbers;

        public PrimeNumbers(int maxPrimeNumber)
        {
            if (maxPrimeNumber < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(maxPrimeNumber));
            }
            MaxPrimeNumber = maxPrimeNumber;
            _primeNumbers = new List<int>() { 2 };
        }

        public List<int> GetPrimes()
        {
            for (var i = 3; i <= MaxPrimeNumber; i += 2)
            {
                var primeCheck = _primeNumbers.All(prime => i % prime != 0);
                if (primeCheck) _primeNumbers.Add(i);
            }
            return _primeNumbers;
        }

        public int SumPrimes()
        {
            return _primeNumbers.Sum();
        }

    }
}