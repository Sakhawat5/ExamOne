using ASP.NETAssignment6.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public class GradeUnitOfWork : UnitOfWork<FrameworkContext>, IGradeUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public ISubjectRepository SubjectRepository { get; set; }
        public IStudentGradeRepository StudentGradeRepository { get; set; }

        public GradeUnitOfWork(string connectionString, string migrationAssemblyName)
            : base(connectionString, migrationAssemblyName)
        {
            StudentRepository = new StudentRepository(_dbContext);
            SubjectRepository = new SubjectRepository(_dbContext);
            StudentGradeRepository = new StudentGradeRepository(_dbContext);
        }
    }
}
