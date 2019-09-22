using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsPractice
{
    class Solution
    {
        public class SumPairs
        {
            public int[] Array { get; set; }
            public int Divisor { get; set; }

            private int _numberOfPairs = 0;

            public SumPairs(int[] array, int divisor)
            {
                Array = array;
                Divisor = divisor;
            }

            public int GetDivisorPairs()
            {
                for (var i = 0; i < Array.Length; i++) GetPairsSum(Array[i], i + 1);

                return _numberOfPairs;
            }

            private void GetPairsSum(int num, int numIndexPlusOne)
            {
                for (var i = numIndexPlusOne; i < Array.Length; i++)
                    if ((num + Array[i]) % Divisor == 0) _numberOfPairs++;
            }
        }

        // Complete the divisibleSumPairs function below.
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            var sumPairs = new SumPairs(ar, k);
            return sumPairs.GetDivisorPairs();
        }

        static void Main(string[] args)
        {
            int n = 6;

            int k = 3;

            int[] ar = new int[] { 1, 3, 2, 6, 1, 2 };

            int result = divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);
        }
    }
}