using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsPractice
{
    static class Program
    {
        private static void Main(string[] args)
        {
            int HouseStart = 7;
            int HouseEnd = 11;
            int AppleTree = 5;
            int OrangeTree = 15;
            List<int> apples = new List<int>() { -2, 2, 1 };
            List<int> oranges = new List<int>() { -2, 2, 1 };
            var fruit = new FallingFruit(HouseStart, HouseEnd, AppleTree, OrangeTree, apples, oranges);
            foreach (var num in fruit.FallingOnHouse())
                Console.WriteLine(num);
        }
    }
}