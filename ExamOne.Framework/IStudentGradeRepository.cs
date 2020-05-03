using ASP.NETAssignment6.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public interface IStudentGradeRepository : IRepository<StudentGradeRepository>
    {
        public IList<StudentGradeRepository> GetLatestStudentRegistration();
    }
}
