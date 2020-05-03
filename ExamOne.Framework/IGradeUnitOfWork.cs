using ASP.NETAssignment6.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public interface IGradeUnitOfWork : IUnitOfWork<FrameworkContext>
    {
        IStudentRepository StudentRepository { get; set; }
        ISubjectRepository SubjectRepository { get; set; }
        IStudentGradeRepository StudentGradeRepository { get; set; }
    }
}
