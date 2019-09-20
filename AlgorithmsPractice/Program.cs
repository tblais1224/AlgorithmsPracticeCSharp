using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsPractice
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var listA = new List<int>() { 2, 4 };
            var listB = new List<int>() { 16, 32, 96 };

            var betweenSets = new BetweenSets(listA, listB);
            Console.WriteLine(betweenSets.IntegersBetween());
        }
    }
}