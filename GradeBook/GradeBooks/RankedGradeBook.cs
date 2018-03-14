using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public string Name { get; set; }
        public RankedGradeBook(string name) : base(name)
        {
            this.Name = name;
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double avarageGrade)
        {
            if(Students.Count <5)
            {
                Console.WriteLine("The number of students should be grater than 5");
                throw new InvalidOperationException();
            }
            var threshold = (int)Math.Ceiling(Students.Count * 0.2);
            var grades = Students.OrderByDescending(j=>j.AverageGrade).Select(e=>e.AverageGrade).ToList();

            if (grades[threshold - 1] <= avarageGrade)
                return 'A';
            else if (grades[(threshold * 2) - 1] <= avarageGrade)
                return 'B';
            else if (grades[(threshold * 3) - 1] <= avarageGrade)
                return 'C';
            else if (grades[(threshold * 4) - 1] <= avarageGrade)
                return 'D';

            return 'F';
        }
    }
}
