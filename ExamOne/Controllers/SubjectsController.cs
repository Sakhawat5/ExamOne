using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamOne.Data;
using ExamOne.Framework;
using Microsoft.AspNetCore.Mvc;

namespace ExamOne.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly StudentGradeContext _studentGradeContext;
        public SubjectsController(StudentGradeContext studentGradeContext)
        {
            _studentGradeContext = studentGradeContext;
        }
        public IActionResult Index()
        {
            var subjects = _studentGradeContext.Subjects.ToList();
            return View(subjects);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            _studentGradeContext.Add(subject);
            _studentGradeContext.SaveChanges();

            return RedirectToAction("Index", "Subjects");
        }
    }
}