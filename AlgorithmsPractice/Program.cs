using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    public class NewYearChaos
    {
        private List<int> _startQueue = new List<int>();
        public List<int> QueueFinalState { get; set; }

        public NewYearChaos(int[] queueFinalState)
        {
            QueueFinalState = queueFinalState.ToList();

        }

        public void Bribes()
        {
            MakeStartQueue();

            int bribes = 0;

            for (int i = 0; i < QueueFinalState.Count; i++)
            {
                if (QueueFinalState[i] == _startQueue[i]) continue;
                bribes = Bribe(i, bribes);
            }

            if (QueueFinalState == _startQueue)
                Console.WriteLine("{0}", bribes);
            else
                Console.WriteLine("Too chaotic");
        }

        private int Bribe(int i, int bribes)
        {
            for (int j = 0; j < 2; j++)
            {
                if (QueueFinalState[i] == _startQueue[i]) break;
                bribes++;
                SwapInts(QueueFinalState[i] - j);
            }

            return bribes;
        }

        private void MakeStartQueue()
        {
            for (int i = 1; i <= QueueFinalState.Count; i++)
                _startQueue.Add(i);
        }

        private void SwapInts(int ValueBribing)
        {
            int temp = _startQueue[ValueBribing - 2];
            _startQueue[ValueBribing - 2] = _startQueue[ValueBribing - 1];
            _startQueue[ValueBribing - 1] = temp;
        }

    }
    class Solution
    {

        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            var bribes = new NewYearChaos(q);
            bribes.Bribes();

        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                    ;
                minimumBribes(q);
            }
        }
    }
}