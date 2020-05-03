using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public interface ISubjectService
    {
        public IList<Subject> GetSubjects(int id, string name, bool RegistrationOpen);
    }
}
