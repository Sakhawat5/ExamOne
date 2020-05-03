using ASP.NETAssignment6.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
        public IList<Student> GetLatestStudents()
        {
            throw new NotImplementedException();
        }
    }
}
