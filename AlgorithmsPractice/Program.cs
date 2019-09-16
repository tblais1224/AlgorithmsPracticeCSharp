using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    public class ChocolateBarDivider
    {
        public List<int> NumbersOnSquares { get; set; }
        public int BirthDay { get; set; }
        public int BirthMonth { get; set; }
        private int _waysToPortionBar = 0;

        public ChocolateBarDivider(List<int> numbersOnSquares, int birthDay, int birthMonth)
        {
            NumbersOnSquares = numbersOnSquares;
            BirthDay = birthDay;
            BirthMonth = birthMonth;
        }

        public int GetPortions()
        {
            var checkNumbers = new List<int>();

            foreach (var numberOnSquare in NumbersOnSquares)
            {
                checkNumbers.Add(numberOnSquare);
                if (checkNumbers.Count != BirthMonth) continue;

                if (checkNumbers.Take(BirthMonth).Sum() == BirthDay)
                    _waysToPortionBar++;

                checkNumbers.RemoveAt(0);
            }

            return _waysToPortionBar;
        }
    }
    class Solution
    {

        // Complete the birthday function below.
        static int birthday(List<int> s, int d, int m)
        {
            var chocolateBarDivider = new ChocolateBarDivider(s, d, m);
            return chocolateBarDivider.GetPortions();
        }

        static void Main(string[] args)
        {
            int n = 5;

            List<int> s = new List<int> { 1, 2, 1, 3, 2 };

            int d = 3;

            int m = 2;

            int result = birthday(s, d, m);

            Console.WriteLine(result);
        }
    }
}
