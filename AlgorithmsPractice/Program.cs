using System;
using System.IO;

namespace AlgorithmsPractice
{
    public class SwapArrays
    {
        public int[] UserArray { get; set; }

        private int _swaps = 0;

        public SwapArrays(int[] userArray)
        {
            UserArray = userArray;
        }

        public int OrderArray()
        {
            for (int i = UserArray.Length -1; i >= 0; i--)
            {
                while (UserArray[i] != i + 1)
                {
                    Sort(i);
                }
            }

            return _swaps;
        }

        private void Sort(int index)
        {
            var temp = UserArray[UserArray[index] - 1];
            UserArray[UserArray[index] - 1] = UserArray[index];
            UserArray[index] = temp;
            _swaps++;
        }
    }
    class Solution
    {

        // Complete the minimumSwaps function below.
        static int minimumSwaps(int[] arr)
        {
            var orderArray = new SwapArrays(arr);
            return orderArray.OrderArray();

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            int res = minimumSwaps(arr);

            Console.WriteLine(res);

        }
    }
}