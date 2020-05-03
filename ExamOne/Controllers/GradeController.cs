using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamOne.Data;
using ExamOne.Framework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ExamOne.Controllers
{
    public class GradeController : Controller
    {
        private readonly StudentGradeContext _studentGradeContext;
        public GradeController(StudentGradeContext studentGradeContext)
        {
            _studentGradeContext = studentGradeContext;
        }
        public IActionResult Index()
        {
            var grade = _studentGradeContext.Grades.Include(x => x.Student).Include(x => x.Subject);
            return View(grade.ToList());
        }
        public IActionResult Create()
        {
            ViewData["studentId"] = new SelectList(_studentGradeContext.Students, "Id", "Name");
            ViewData["subjectId"] = new SelectList(_studentGradeContext.Subjects, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Grade grade)
        {

            _studentGradeContext.Add(grade);
            _studentGradeContext.SaveChanges();

            return RedirectToAction("Index", "Grade");
        }
    }
}