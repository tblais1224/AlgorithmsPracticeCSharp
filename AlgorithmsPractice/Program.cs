using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    static class Program
    {
        public class YearRelationship
        {
            public float Year { get; set; }
            public float Month { get; set; }

            private readonly float _currentMonth = DateTime.Now.Month;
            private readonly float _currentYear = DateTime.Now.Year;
            public YearRelationship(int year, int month)
            {
                Year = year;
                Month = month;
            }

            public double DetermineDateRelationship()
            {
                return Year > _currentYear ? Math.Round((Year - _currentYear + (Month - _currentMonth) / 12), 2) : Math.Round(_currentYear - Year + (_currentMonth - Month) / 12, 2);
            }
        }
        static void Main(string[] args)
        {
            //TODO: Given a month and year determine the 2 decimal year value in relation to today.  input = year month, output = x.xx years

            var yearRelationship = new YearRelationship(2018, 10);

            Console.WriteLine(yearRelationship.DetermineDateRelationship());
        }
    }
}
