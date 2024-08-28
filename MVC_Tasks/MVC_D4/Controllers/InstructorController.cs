using Microsoft.AspNetCore.Mvc;
using MVC_D2.Context;
using MVC_D2.Models;


namespace MVC_D2.Controllers
{
    public class InstructorController : Controller
    {
        StudentContext context = new StudentContext();
        public ActionResult GetAll()
        {
            var instructors = context.Instructors.ToList();
            var depts = context.Departments.ToDictionary(x => x.Id, x => x.Name);
            ViewBag.depts = depts;
            return View(instructors);
        }
        public ActionResult GetById(int id)
        {
            var instructor = context.Instructors.FirstOrDefault(x => x.Id == id);
            return View(instructor);
        }
        //new
        [HttpGet]
        public IActionResult New()
        {
            var depts = context.Departments.ToList();
            ViewBag.depts = depts;
            return View();
        }
        //Save
        [HttpPost]
        public IActionResult Save(Instructor instructor)
        {
            if (instructor.Name!=null)
            {
                context.Instructors.Add(instructor);
                context.SaveChanges();
                return RedirectToAction("GetAll");
            }
            else
            {
                var depts = context.Departments.ToList();
                ViewBag.depts = depts;
                return View("New", instructor);
            }
        }
        //Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var instructor = context.Instructors.FirstOrDefault(x => x.Id == id);
            var depts = context.Departments.ToList();
            ViewBag.depts = depts;
            return View(instructor);
        }
        //EditSave
        [HttpPost]
        public IActionResult EditSave(Instructor instructor)
        {
            if (instructor.Name != null)
            {
                context.Instructors.Update(instructor);
                context.SaveChanges();
                return RedirectToAction("GetAll");
            }
            return View("Edit", instructor);
        }
        //Delete
        [HttpGet]
        public IActionResult Delete(int id) {
            var instructor = context.Instructors.FirstOrDefault(x => x.Id == id);
            context.Instructors.Remove(instructor);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        //Details
        public IActionResult Details(int id)
        {
            var instructor = context.Instructors.FirstOrDefault(x => x.Id == id);
            return View(instructor);
        }
    }
}