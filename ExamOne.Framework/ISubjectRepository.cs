using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public interface ISubjectRepository
    {
        IList<Subject> GetLatestSubjects();
    }
}
