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
            return View(students);
        }
        //GetById
        public ActionResult GetById(int id)
        {
            var student = context.Students.FirstOrDefault(x => x.Id == id);
            return View(student);
        }
        //Day 3
        //// new
        //[HttpGet]
        //public IActionResult New()
        //{
        //    return View();
        //}
        //// Save
        //[HttpPost]
        //public IActionResult Save(Student student)
        //{
        //    if (student.Name != null)
        //    {
        //        context.Students.Add(student);
        //        context.SaveChanges();
        //        return RedirectToAction("GetAll");
        //    }
        //    else
        //    {
        //        return View("New",student);
        //    }
        //}
        //// Edit
        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var student = context.Students.FirstOrDefault(x => x.Id == id);
        //    return View(student);
        //}
        ////EditSave
        //[HttpPost]
        //public IActionResult EditSave(Student student)
        //{
        //    if (student.Name != null)
        //    {
        //        context.Students.Update(student);
        //        context.SaveChanges();
        //        return RedirectToAction("GetAll");
        //    }
        //    return View("Edit", student);
        //}
        ////Delete
        //public IActionResult Delete(int id)
        //{
        //    var student = context.Students.FirstOrDefault(x => x.Id == id);
        //    context.Students.Remove(student);
        //    context.SaveChanges();
        //    return RedirectToAction("GetAll");
        //}
    }
}
