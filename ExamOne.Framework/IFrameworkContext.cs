using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamOne.Framework
{
    public interface IFrameworkContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<Grade> Grades { get; set; }
    }
}
