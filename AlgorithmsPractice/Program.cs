using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;

namespace AlgorithmsPractice
{

    public class RansomNote
    {
        public Dictionary<string, int> Magazine { get; set; }

        public string[] Note { get; set; }

        public RansomNote(string[] note)
        {
            Note = note;
        }

        private void BuildDictionary(string[] magazine)
        {
            Magazine = new Dictionary<string, int>();
            foreach (var word in magazine)
            {
                if (!Magazine.ContainsKey(word)) Magazine.Add(word, 1);
                else Magazine[word]++;
            }
        }

        public string CanMakeRansomNote(string[] magazine)
        {
            BuildDictionary(magazine);

            foreach (var word in Note)
            {
                if (!Magazine.ContainsKey(word) || Magazine[word] == 0) return "No";
                else Magazine[word]--;
            }

            return "Yes";
        }
    }
    class Solution
    {

        // Complete the checkMagazine function below.
        static void checkMagazine(string[] magazine, string[] note)
        {
            var ransom = new RansomNote(note);
            Console.WriteLine(ransom.CanMakeRansomNote(magazine));

        }

        static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }
    }
}