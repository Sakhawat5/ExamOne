using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public interface IStudentService
    {
        public IList<Student> GetStudent(int id, string name, string username, string email);
    }
}
