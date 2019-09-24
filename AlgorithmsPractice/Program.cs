using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsPractice
{

    public class ProgrammerDay
    {
        public int Year { get; set; }

        public ProgrammerDay(int year)
        {
            Year = year;
        }
        public String DayOfProgrammer()
        {
            if (Year == 1918) return "26.09.1918";
            else if (((Year <= 1917) && (Year % 4 == 0)) ||
                     ((Year > 1918) && (Year % 400 == 0 || ((Year % 4 == 0) && (Year % 100 != 0)))))
                return $"12.09.{Year}";
            else return $"13.09.{Year}";
        }
    }
    class Solution
    {

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            var dateClass = new ProgrammerDay(year);
            return dateClass.DayOfProgrammer();
        }

        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = dayOfProgrammer(year);

            Console.WriteLine(result);
        }
    }
}