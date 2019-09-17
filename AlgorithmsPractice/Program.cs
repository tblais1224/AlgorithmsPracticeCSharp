using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsPractice
{
    static class Program
    {
        public static int GetFactorialize(int numberToFactorialize)
        {
            if (numberToFactorialize == 0) return 1;
            return numberToFactorialize * GetFactorialize(numberToFactorialize - 1);
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(Program.GetFactorialize(5));
        }
    }
}