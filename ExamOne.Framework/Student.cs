using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamOne.Framework
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Student Name")]
        public string Name { get; set; }

        public string Username { get; set; }
        public string Email { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
