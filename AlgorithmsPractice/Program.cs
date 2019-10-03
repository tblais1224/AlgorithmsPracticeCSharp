using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    static class Solution
    {

        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            var valleys = 0;
            var checkPosition = 0;

            foreach (var letter in s)
            {
                if (letter == 'U')
                {
                    checkPosition++;
                }
                else if (checkPosition == 0)
                {
                    valleys++;
                    checkPosition--;
                }
                else
                {
                    checkPosition--;
                }
            }

            return valleys;
        }

        static void Main(string[] args)
        {
            int n = 12;

            string s = "DDUUDDUDUUUD";

            int result = countingValleys(n, s);

            Console.WriteLine(result);

        }
    }
}