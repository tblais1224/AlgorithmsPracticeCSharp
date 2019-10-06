using System;
using System.IO;
using System.Linq;

namespace AlgorithmsPractice
{
    class Solution
    {

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            var arrayCopy = a.ToList();
            for (int i = 0; i < d; i++)
            {
                arrayCopy.Add(arrayCopy[0]);
                arrayCopy.RemoveAt(0);
            }

            return arrayCopy.ToArray();
        }

        static void Main(string[] args)
        {

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));

        }
    }
}