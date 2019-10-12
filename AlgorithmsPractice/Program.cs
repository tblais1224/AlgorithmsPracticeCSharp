using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    class Solution
    {

        // Complete the twoStrings function below.
        static string twoStrings(string s1, string s2)
        {
            return s2.Any(MakeDictionary(s1).ContainsValue) ? "YES" : "NO";
        }
        static Dictionary<int, char> MakeDictionary(string s1)
        {
            var s1Dict = new Dictionary<int, char>();
            foreach (var letter in s1.Where(letter => !s1Dict.ContainsValue(letter)))
                s1Dict.Add(s1.IndexOf(letter), letter);

            return s1Dict;
        }

        static void Main(string[] args)
        {

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                Console.WriteLine(result);
            }
        }
    }
}