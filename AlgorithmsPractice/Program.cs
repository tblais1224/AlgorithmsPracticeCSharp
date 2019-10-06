using System;

namespace AlgorithmsPractice
{
    class Solution
    {

        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {


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