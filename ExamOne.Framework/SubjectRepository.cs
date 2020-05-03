using ASP.NETAssignment6.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository(DbContext dbContext)
            :base(dbContext)
        {

        }
        public IList<Subject> GetLatestSubjects()
        {
            throw new NotImplementedException();
        }
    }
}
