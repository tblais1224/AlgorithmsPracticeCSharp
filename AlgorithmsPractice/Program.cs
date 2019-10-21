using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgorithmsPractice
{
    public class BubbleSort
    {
        public int[] Arr { get; set; }
        public int Swaps { get; set; }

        public BubbleSort(int[] arr)
        {
            Arr = arr;
            Swaps = 0;
        }

        public int[] SortArray()
        {
            if (Swaps != 0) Swaps = 0;

            foreach (var element in Arr)
            {
                for (int j = 0; j < Arr.Length - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (Arr[j] > Arr[j + 1])
                    {
                        swap(j);
                    }
                }
            }

            return Arr;
        }

        private void swap(int index)
        {
            Swaps++;
            int original = Arr[index];
            Arr[index] = Arr[index + 1];
            Arr[index + 1] = original;
        }
    }

    static class Solution
    {

        // Complete the countSwaps function below.
        static void countSwaps(int[] a)
        {
            var sort = new BubbleSort(a);
            sort.SortArray();
            Console.WriteLine("Array is sorted in {0} swaps.", sort.Swaps);
            Console.WriteLine("First Element: {0}", sort.Arr[0]);
            Console.WriteLine("Last Element: {0}", sort.Arr[sort.Arr.Length - 1]);

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
            countSwaps(a);
        }
    }

}