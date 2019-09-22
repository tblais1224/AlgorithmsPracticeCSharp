using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsPractice
{
    public class Records
    {
        public int[] Scores { get; set; }
        private readonly int[] _highAndLowRecord;
        private readonly int[] _highAndLowRecordCounter;

        public Records(int[] scores)
        {
            Scores = scores;
            _highAndLowRecord = new[] { scores[0], scores[0] };
            _highAndLowRecordCounter = new[] { 0, 0 };
        }

        public int[] NumberOfTimesRecordBroken()
        {
            foreach (var score in Scores)
            {
                GetHighRecord(score);
                GetLowRecord(score);
            }

            return _highAndLowRecordCounter;
        }

        private void GetLowRecord(int score)
        {
            if (score < _highAndLowRecord[1])
            {
                _highAndLowRecord[1] = score;
                _highAndLowRecordCounter[1]++;
            }
        }

        private void GetHighRecord(int score)
        {
            if (score > _highAndLowRecord[0])
            {
                _highAndLowRecord[0] = score;
                _highAndLowRecordCounter[0]++;
            }
        }
    }
    class Solution
    {

        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            var records = new Records(scores);
            return records.NumberOfTimesRecordBroken();
        }

        static void Main(string[] args)
        {
            int[] scores = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}