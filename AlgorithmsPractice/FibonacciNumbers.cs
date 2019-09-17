using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice
{
    public class FibonacciNumbers
    {
        public int GreatestFibonacciNumber { get; set; }

        private readonly List<int> _fibonacciNumbers;

        public FibonacciNumbers(int greatestFibonacciNumber)
        {
            GreatestFibonacciNumber = greatestFibonacciNumber;
            _fibonacciNumbers = new List<int> { 0, 1 };
        }

        public List<int> GetFibonacciNumbers()
        {
            while (true)
            {
                var fibonacciNumber = _fibonacciNumbers[_fibonacciNumbers.Count - 1] + _fibonacciNumbers[_fibonacciNumbers.Count - 2];
                _fibonacciNumbers.Add(fibonacciNumber);
                if (fibonacciNumber + _fibonacciNumbers[_fibonacciNumbers.Count - 2] <= GreatestFibonacciNumber) continue;
                break;
            }

            return _fibonacciNumbers;
        }

        public int SumOddFibonacciNumber()
        {
            return _fibonacciNumbers.Where(number => number % 2 != 0).Sum();
        }
    }
}
