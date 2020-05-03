using ASP.NETAssignment6.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public class GradeRepository : Repository<Grade>, IGradeRepository
    {
        public GradeRepository(DbContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Grade> GetLatestGrades()
        {
            throw new NotImplementedException();
        }
    }
}
