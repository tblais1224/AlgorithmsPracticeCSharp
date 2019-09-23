using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsPractice
{
    public class SumAll
    {
        public int[] ArrayNumbers { get; set; }

        public SumAll(int[] arraysNumbers)
        {
            ArrayNumbers = arraysNumbers;
        }

        public int SumArray()
        {
            var result = 0;
            for (int i = ArrayNumbers.Min(); i <= ArrayNumbers.Max(); i++) result += i;

            return result;
        }
    }
    class Solution
    {
        static void Main(string[] args)
        {

        }
    }
}