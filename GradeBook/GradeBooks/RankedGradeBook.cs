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
            

            else return 'F';

        }
    }

}
