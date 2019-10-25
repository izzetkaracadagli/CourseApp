using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Data.Abstract;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controlers
{
    public class InstructorController : Controller
    {
        private IInstructorRepository irepo;
        private ICourseRepository crepo;
        public InstructorController(IInstructorRepository _irepo, ICourseRepository _crepo )
        {
            irepo = _irepo;
            crepo = _crepo;
        }
        public IActionResult Index()
        {
            ViewBag.InstructorEditId = TempData["InstructorEditId"];
            ViewBag.InstructorCreateId = TempData["InstructorCreateId"];
            ViewBag.InstructorChangeId = TempData["InstructorChangeId"];
            
            return View(irepo.GetAll());
        }
        public IActionResult Edit(int id)
        {
            TempData["InstructorEditId"] = id;
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Instructor entity)
        {
            irepo.Update(entity);
            return RedirectToAction("Index");
        }
        public IActionResult Create(int id)
        {
            TempData["InstructorCreateId"] = id;
            return RedirectToAction("Index");
        }
       
        public IActionResult Change(int id)
        {
            TempData["InstructorChangeId"] = id;
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Change(int id,Course[] courses)
        {
            crepo.UpdateAll(id, courses);
            return RedirectToAction("Index");
        }
    }
}