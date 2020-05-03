using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamOne.Data;
using ExamOne.Framework;
using Microsoft.AspNetCore.Mvc;

namespace ExamOne.Controllers
{

    public class StudentsController : Controller
    {
        public readonly StudentGradeContext _studentGradeContext;

        public StudentsController(StudentGradeContext studentGradeContext)
        {
            _studentGradeContext = studentGradeContext;
        }
        public IActionResult Index()
        {
            var students = _studentGradeContext.Students.ToList();
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _studentGradeContext.Add(student);
            _studentGradeContext.SaveChanges();

            return View(student);
        }

    }
}