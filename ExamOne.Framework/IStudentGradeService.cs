using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public interface IStudentGradeService
    {
        public IList<Grade> GetGrade(int id, int studentId, int subjectId, decimal GradeValue);
    }
}
