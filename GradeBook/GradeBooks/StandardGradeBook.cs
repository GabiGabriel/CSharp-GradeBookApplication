using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public string Name { get; set; }
        public GradeBookType Type { get; set; }
        public StandardGradeBook(string name) : base(name)
        {
            this.Name = name;
            Type = GradeBookType.Standard;
        }
    }
}
