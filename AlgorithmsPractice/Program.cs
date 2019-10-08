using System;
using System.IO;
using System.Linq;

namespace AlgorithmsPractice
{
    public class ArrayManipulation
    {
        public int ArrayLength { get; set; }
        public int[][] UserData { get; set; }
        private long[] _newArray;

        public ArrayManipulation(int n, int[][] userData)
        {
            ArrayLength = n;
            UserData = userData;
            _newArray = new long[ArrayLength + 2];

        }

        public long ManipulateArray()
        {
            foreach (var data in UserData)
            {
                _newArray[data[0]] += data[2];
                _newArray[data[1] + 1] -= data[2];
            }

            return GetMax();
        }

        public long GetMax()
        {
            long max = 0;
            long temp = 0;

            foreach (var num in _newArray)
            {
                temp += num;
                if (temp > max) max = temp;
            }

            return max;
        }

    }
    class Solution
    {

        // Complete the arrayManipulation function below.
        static long arrayManipulation(int n, int[][] queries)
        {
            return new ArrayManipulation(n, queries).ManipulateArray();
        }

        static void Main(string[] args)
        {


            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);

            Console.WriteLine(result);

        }
    }
}