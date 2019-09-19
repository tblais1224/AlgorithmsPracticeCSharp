using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    public class Grader
    {
        public List<int> OriginalGrades { get; set; }
        public List<int> FinalGrades { get; set; }

        public Grader(List<int> originalGrades)
        {
            OriginalGrades = originalGrades;
            FinalGrades = new List<int>();
        }

        public List<int> GetFinalGrades()
        {
            foreach (var grade in OriginalGrades)
                FinalGrades.Add(CheckForFailingGrade(grade));

            return FinalGrades;
        }

        private static int CheckForFailingGrade(int grade)
        {
            return grade < 38 ? grade : RoundGradeToMultipleOfFive(grade);
        }

        private static int RoundGradeToMultipleOfFive(int grade)
        {
            return grade % 5 >= 3 ? 5 - (grade % 5) + grade : grade;
        }
    }
}