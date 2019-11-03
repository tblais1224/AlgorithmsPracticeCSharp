using System;
using System.Collections.Generic;

namespace AlgorithmsPractice
{
    public class Queue
    {
        private List<int> _queue = new List<int>();

        public void Enqueue(int num)
        {
            _queue.Add(num);
        }

        public int Dequeue()
        {
            int output = _queue[0];
            _queue.Remove(output);
            return output;
        }

        public void PrintFront()
        {
            Console.WriteLine(_queue[0]);
        }
    }
    class Solution
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var queue = new Queue();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                if (Convert.ToInt32(input[0]) == 1)
                {
                    queue.Enqueue(Convert.ToInt32(input[1]));
                }
                else if (Convert.ToInt32(input[0]) == 2)
                {
                    queue.Dequeue();
                }
                else
                {
                    queue.PrintFront();
                }
            }
        }
    }
}