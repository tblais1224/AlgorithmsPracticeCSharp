using System;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmsPractice
{
    public class Anagrams
    {
        public string InputString { get; set; }

        public Anagrams(string inputString)
        {
            InputString = inputString;
        }

        private Dictionary<string, int> AllPossibleSubstrings()
        {
            var substrings = new Dictionary<string, int>();
        }
    }
    class Solution
    {

        // Complete the sherlockAndAnagrams function below.
        static int sherlockAndAnagrams(string s)
        {
            var anagrams = new Anagrams(s);

        }

        static void Main(string[] args)
        {

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = sherlockAndAnagrams(s);

                Console.WriteLine(result);
            }
        }
    }
}