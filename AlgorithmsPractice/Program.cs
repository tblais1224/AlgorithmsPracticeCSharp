using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    public class HighScores
    {
        public List<int> Scores { get; set; }

        public HighScores(int[] scores)
        {
            Scores = scores.ToList();
        }

        public int[] ScoreRankings(int[] checkScores)
        {
            var rankings = new List<int>();
            var noDuplicateScores = RemoveDuplicates(Scores);

            foreach (var score in checkScores)
            {
                for (var i = 0; i <= noDuplicateScores.Count; i++)
                {
                    if (i == noDuplicateScores.Count || score >= noDuplicateScores[i])
                    {
                        rankings.Add(i + 1);
                        break;
                    }
                }
            }

            return rankings.ToArray();
        }

        private List<int> RemoveDuplicates(List<int> withDuplicates)
        {
            return withDuplicates.Distinct().ToList();
        }
    }
    static class Program
    {
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            return new HighScores(scores).ScoreRankings(alice);
        }
        private static void Main(string[] args)
        {
            int scoresCount = 6;
            int[] scores = { 100, 90, 90, 80, 75, 60 };

            int aliceCount = 5;
            int[] alice = { 50, 65, 77, 90, 102 };

            int[] result = climbingLeaderboard(scores, alice);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}