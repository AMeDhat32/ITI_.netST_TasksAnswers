using Microsoft.AspNetCore.Mvc;
using MVC_D2.Context;
using MVC_D2.Models;

namespace MVC_D2.Controllers
{
    public class CourseController : Controller
    {
        StudentContext context = new StudentContext();
        //GetAll
        public ActionResult GetAll()
        {
            var Courses = context.Courses.ToList();
            var depts = context.Departments.ToDictionary(x => x.Id, x => x.Name);
            ViewBag.depts = depts;
            return View(Courses);
        }
        //GetById
        public ActionResult GetById(int id)
        {
            var course = context.Courses.FirstOrDefault(x => x.Id == id);
            return View(course);
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
        public IActionResult Save(Course course)
        {
            if (course.Name != null)
            {
                context.Courses.Add(course);
                context.SaveChanges();
                return RedirectToAction("GetAll");
            }
            else
            {
                return View("New", course);
            }
        }
        //Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var course = context.Courses.FirstOrDefault(x => x.Id == id);
            var depts = context.Departments.ToList();
            ViewBag.depts = depts;
            return View(course);
        }
        //EditSave
        [HttpPost]
        public IActionResult EditSave(Course course)
        {
            if (course.Name != null)
            {
                context.Courses.Update(course);
                context.SaveChanges();
                return RedirectToAction("GetAll");
            }
            else
            {
                return View("Edit", course);
            }
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var course = context.Courses.FirstOrDefault(x => x.Id == id);
            return View(course);
        }
        [HttpPost]
        public IActionResult Delete(int id)

        {
            var course = context.Courses.FirstOrDefault(x => x.Id == id);
            context.Courses.Remove(course);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
