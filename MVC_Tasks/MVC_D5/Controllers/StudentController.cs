using Microsoft.AspNetCore.Mvc;
using MVC_D2.Context;
using MVC_D2.Models;

namespace MVC_D2.Controllers
{
    public class StudentController : Controller
    {
        StudentContext context = new StudentContext();

        //GetAll
        public ActionResult GetAll()
        {
            var students = context.Students.ToList();
            var depts = context.Departments.ToDictionary(x => x.Id, x => x.Name);
            ViewBag.depts = depts;
            return View(students);
        }
        //GetById
        public ActionResult GetById(int id)
        {
            var student = context.Students.FirstOrDefault(x => x.Id == id);
            return View(student);
        }

        // new
        [HttpGet]
        public IActionResult New()
        {
            var depts = context.Departments.ToList();
            ViewBag.depts = depts;

            return View();
        }
        // Save
        [HttpPost]
        public IActionResult Save(Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("GetAll");
            }
            var depts = context.Departments.ToList();
            ViewBag.depts = depts;
            return View("New", student);
            
        }
        // Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = context.Students.FirstOrDefault(x => x.Id == id);
            var depts = context.Departments.ToList();
            ViewBag.depts = depts;
            return View(student);
        }
        //EditSave
        [HttpPost]
        public IActionResult EditSave(Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Update(student);
                context.SaveChanges();
                return RedirectToAction("GetAll");
            }
            var depts = context.Departments.ToList();
            ViewBag.depts = depts;
            return View("Edit", student);
        }
        //Delete
        public IActionResult Delete(int id)
        {
            var student = context.Students.FirstOrDefault(x => x.Id == id);
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }

        //Details
        public IActionResult Details(int id)
        {
            var student = context.Students.FirstOrDefault(x => x.Id == id);
            return View(student);
        }
    }
}