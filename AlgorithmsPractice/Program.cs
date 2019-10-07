using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    static class Solution
    {

        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            int bribes = 0;
            bool check = true;
            int minNum = q.Length;
            for (int i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] - i > 3)
                {
                    Console.WriteLine("Too chaotic");
                    check = false;
                    break;
                }

                if (q[i] - 3 == i)
                {
                    bribes += 2;
                }
                else
                {
                    if (minNum > q[i])
                        minNum = q[i];
                    else if (q[i] != minNum)
                    {
                        bribes++;
                    }
                }
            }

            if (check) Console.WriteLine("{0}", bribes);
        }


        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                    ;
                minimumBribes(q);
            }
        }
    }
}