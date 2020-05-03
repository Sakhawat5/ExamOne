using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamOne.Framework
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Subject Name")]
        public string Name { get; set; }
        public bool RegistrationOpen { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
