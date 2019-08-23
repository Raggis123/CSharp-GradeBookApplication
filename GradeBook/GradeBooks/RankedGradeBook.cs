using GradeBook.Enums;
using System;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averangeGrade)
        {
            if(Students.Count < 5)
                throw new InvalidOperationException("Ranked grades needs atleast 5 students");
            
            var treshold = (int)Math.Ceiling(Students.Count * 0.2);
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            if (grades[treshold - 1] <= averangeGrade)
                return 'A';
            else if (grades[(treshold * 2) - 1] <= averangeGrade)
                return 'B';
            else if (grades[(treshold * 3) - 1] <= averangeGrade)
                return 'C';
            else if (grades[(treshold * 4) - 1] <= averangeGrade)
                return 'D';
            else
                return 'F';

        }
    }

}
