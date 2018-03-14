using GradeBook.Enums;
using System;
using System.Collections.Generic;
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
    }
}
