using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public class Grade
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public decimal GradeValue { get; set; }
        public Subject Subject { get; set; }
        public Student Student { get; set; }

    }
}
