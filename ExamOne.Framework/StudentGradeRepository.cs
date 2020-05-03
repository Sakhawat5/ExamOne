using ASP.NETAssignment6.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public class StudentGradeRepository : Repository<StudentGradeRepository>, IStudentGradeRepository
    {
        public StudentGradeRepository(DbContext dbContext) : base(dbContext)
        {

        }
        public IList<StudentGradeRepository> GetLatestStudentRegistration()
        {
            throw new NotImplementedException();
        }
    }
}
