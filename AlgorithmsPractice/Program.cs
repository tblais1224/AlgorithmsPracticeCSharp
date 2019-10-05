using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    class Solution
    {

        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;

            for (int i = 0; i < c.Length - 1; i++)
            {
                if (i == c.Length - 2 || c[i + 2] == 1)
                {
                    jumps++;
                }
                else
                {
                    jumps++;
                    i++;
                }
            }

            return jumps;
        }

        static void Main(string[] args)
        {
            int[] c = { 0, 0, 0, 1, 0, 0 };

            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
        }
    }
}