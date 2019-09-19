using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    public class FallingFruit
    {
        public int HouseStart { get; set; }
        public int HouseEnd { get; set; }
        public int AppleTree { get; set; }
        public int OrangeTree { get; set; }
        public List<int> Apples { get; set; }
        public List<int> Oranges { get; set; }

        private readonly List<int> _landingOnHouse = new List<int>();

        public FallingFruit(int houseStart, int houseEnd, int appleTree, int orangeTree, List<int> apples, List<int> oranges)
        {
            HouseStart = houseStart;
            HouseEnd = houseEnd;
            AppleTree = appleTree;
            OrangeTree = orangeTree;
            Apples = apples;
            Oranges = oranges;
        }

        public List<int> FallingOnHouse()
        {
            _landingOnHouse.Add(CountFruitFallingOnHouse(AppleTree, Apples));
            _landingOnHouse.Add(CountFruitFallingOnHouse(OrangeTree, Oranges));
            return _landingOnHouse;
        }

        private int CountFruitFallingOnHouse(int treeLocation, IEnumerable<int> fruit)
        {
            return FruitLandingPosition(treeLocation, fruit).Count(landingPosition => landingPosition >= HouseStart && landingPosition <= HouseEnd);
        }

        private static IEnumerable<int> FruitLandingPosition(int treeLocation, IEnumerable<int> apples)
        {
            return apples.Select(apple => apple + treeLocation).ToList();
        }
    }
}