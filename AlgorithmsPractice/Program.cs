using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var sumFibs = new FibonacciNumbers(10);
            sumFibs.GetFibonacciNumbers();
            Console.WriteLine(sumFibs.SumOddFibonacciNumber());
        }
    }
}