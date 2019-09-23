using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsPractice
{

    public class MigratoryBirds
    {
        public List<int> Birds { get; set; }
        private Dictionary<int, int> _birds = new Dictionary<int, int>();
        private int _mostFrequentBird;
        public MigratoryBirds(List<int> birds)
        {
            Birds = birds;
            _mostFrequentBird = birds[0];
        }

        public int MostFrequentBird()
        {
            BuildBirdDictionary();
            foreach (var bird in _birds.Where(bird => bird.Value >= _birds[_mostFrequentBird]))
            {
                if (bird.Key >= _mostFrequentBird && bird.Value == _birds[_mostFrequentBird]) continue;
                _mostFrequentBird = bird.Key;
            }

            return _mostFrequentBird;
        }

        private void BuildBirdDictionary()
        {
            foreach (var id in Birds)
            {
                if (_birds.ContainsKey(id))
                    AddToExistingBird(id);
                else
                    AddNewBirdToDictionary(id);
            }
        }

        private void AddNewBirdToDictionary(int id)
        {
            _birds.Add(id, 1);
        }

        private void AddToExistingBird(int id)
        {
            _birds[id]++;
        }
    }
    class Solution
    {
        static int migratoryBirds(List<int> arr)
        {
            var birds = new MigratoryBirds(arr);
            return birds.MostFrequentBird();
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
        }

    }
}