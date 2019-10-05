using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace AlgorithmsPractice
{
    class Solution
    {

        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            var result = n / s.Length * s.Count(c => c == 'a');

            for (int i = 0; i < n % s.Length; i++)
                if (s[i] == 'a')
                    result++;

            return result;

        }

        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);

        }
    }

}