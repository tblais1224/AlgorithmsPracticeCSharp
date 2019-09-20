using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    public class BetweenSets
    {
        public List<int> ListA { get; set; }
        public List<int> ListB { get; set; }

        private int _integersBetweenResult;
        public BetweenSets(List<int> listA, List<int> listB)
        {
            ListA = listA;
            ListB = listB;
            _integersBetweenResult = 0;
        }

        public int IntegersBetween()
        {

            foreach (var number in GetFactorsBetweenLists())
                if (ListB.All(num => num % number == 0)) _integersBetweenResult++;

            return _integersBetweenResult;
        }

        private List<int> GetFactorsBetweenLists()
        {
            var listAFactors = new List<int>();

            for (var i = ListB.Min(); i >= ListA.Max(); i--)
                if (VerifyListFactors(i, ListA)) listAFactors.Add(i);

            return listAFactors;
        }

        private bool VerifyListFactors(int checkNum, List<int> list)
        {
            return list.All(num => checkNum % num == 0);
        }
    }
}