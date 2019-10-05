using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AlgorithmsPractice
{
    class Solution
    {

        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            return GetSums(arr).Max();

        }

        static List<int> GetSums(int[][] arr)
        {
            var sums = new List<int>();
            for (int i = 0; i <= arr[0].Length / 2; i++)
            {
                for (int j = 0; j <= arr[0].Length / 2; j++)
                    sums.Add(arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);
            }
            return sums;
        }

        static void Main(string[] args)
        {

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine(result);

        }
    }
}