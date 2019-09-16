using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    static class Program
    {
        public class SumOddFibonacciNumbers
        {
            public int FibsLessThanMe { get; set; }

            private readonly List<int> _fibonacciNumbers = new List<int> { 0, 1 };

            public SumOddFibonacciNumbers(int fibsLessThanMe)
            {
                FibsLessThanMe = fibsLessThanMe;
            }

            private void GetFibonacciNumbers()
            {
                while (true)
                {
                    var fibonacciNumber = _fibonacciNumbers[_fibonacciNumbers.Count - 1] + _fibonacciNumbers[_fibonacciNumbers.Count - 2];
                    _fibonacciNumbers.Add(fibonacciNumber);
                    if (fibonacciNumber + _fibonacciNumbers[_fibonacciNumbers.Count - 2] <= FibsLessThanMe) continue;
                    break;
                }
            }

            public int SumOddFibonacciNumber()
            {
                GetFibonacciNumbers();
                return _fibonacciNumbers.Where(number => number % 2 != 0).Sum();
            }
        }

        private static void Main(string[] args)
        {
            var sumFibs = new SumOddFibonacciNumbers(4000000);
            Console.WriteLine(sumFibs.SumOddFibonacciNumber());
        }
    }
}
