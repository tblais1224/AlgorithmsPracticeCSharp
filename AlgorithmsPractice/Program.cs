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
            List<int> grades = new List<int>() { 73, 67, 38, 33 };
            var grader = new Grader(grades);
            foreach (var grade in grader.GetFinalGrades())
                Console.WriteLine(grade);
        }
    }
}