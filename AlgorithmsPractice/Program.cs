using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsPractice
{
    public class MagicSquares
    {
        private readonly List<int[,]> _magicSquares = new List<int[,]>()
        {
            new int[,] { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } },
            new int[,] { { 6, 1, 8 }, { 7, 5, 3 }, { 2, 9, 4 } },
            new int[,] { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } },
            new int[,] { { 2, 9, 4 }, { 7, 5, 3 }, { 6, 1, 8 } },
            new int[,] { { 8, 3, 4 }, { 1, 5, 9 }, { 6, 7, 2 } },
            new int[,] { { 4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 } },
            new int[,] { { 6, 7, 2 }, { 1, 5, 9 }, { 8, 3, 4 } },
            new int[,] { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } },
        };

        public int[][] NotMagicSquare { get; set; }
        public MagicSquares(int[][] notMagicSquare)
        {
            NotMagicSquare = notMagicSquare;
        }

        public int MinCostToMakeSquareMagic()
        {
            int minCost = 10000;
            foreach (var magicSquare in _magicSquares)
            {
                if (CostToChangeSquare(magicSquare) < minCost) minCost = CostToChangeSquare(magicSquare);
            }
            return minCost;
        }

        private int CostToChangeSquare(int[,] magicSquare)
        {
            int cost = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cost += Math.Abs(magicSquare[i, j] - NotMagicSquare[i][j]);
                }
            }
            return cost;
        }
    }
    static class Program
    {
        static int formingMagicSquare(int[][] s)
        {

            return new MagicSquares(s).MinCostToMakeSquareMagic();
        }
        private static void Main(string[] args)
        {
            int[][] s = new int[3][] { };

            int result = formingMagicSquare(s);

            Console.WriteLine(result);
        }
    }
}