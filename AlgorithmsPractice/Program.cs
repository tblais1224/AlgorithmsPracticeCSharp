using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    public class DnaHealth
    {
        public string[] Genes { get; set; }
        public int[] GeneHealth { get; set; }

        private int _bestHealth = 0;
        private int _worstHealth = 10000000;


        public DnaHealth(string[] genes, int[] geneHealth)
        {
            Genes = genes;
            GeneHealth = geneHealth;

        }

        public int GetHealth(int first, int last, string dna)
        {
            var health = 0;

            for (int i = first; i <= last; i++)
            {
                for (int dnaIndex = 0; dnaIndex < dna.Length; dnaIndex++)
                {
                    if (dna.Length - dnaIndex >= Genes[i].Length && Genes[i] == dna.Substring(dnaIndex, Genes[i].Length))
                    {
                        health += GeneHealth[i];
                    }
                }
            }

            SetBestWorstHealth(health);
            return health;
        }

        private void SetBestWorstHealth(int health)
        {
            if (health > _bestHealth) _bestHealth = health;
            if (health < _worstHealth) _worstHealth = health;
        }

        public void PrintBestAndWorstHealth()
        {
            Console.WriteLine("{0} {1}", _worstHealth, _bestHealth);
        }

    }
    class Solution
    {

        static void Main(string[] args)
        {
            int n = 6;

            string[] genes = { "a", "b", "c", "aa", "d", "b" };

            int[] health = { 1, 2, 3, 4, 5, 6 };

            var dnaHealth = new DnaHealth(genes, health);

            int s = 3;

            string[] inputs = { "1 5 caaab", "0 4 xyz", "2 4 bcdybc" };

            foreach (var input in inputs)
            {
                string[] firstLastd = input.Split(' ');

                int first = Convert.ToInt32(firstLastd[0]);

                int last = Convert.ToInt32(firstLastd[1]);

                string d = firstLastd[2];

                dnaHealth.GetHealth(first, last, d);
            }
            dnaHealth.PrintBestAndWorstHealth();
        }
    }
}