using Microsoft.AspNetCore.Mvc;
using MVC_D2.Context;
using MVC_D2.Models;

namespace MVC_D2.Controllers
{
    public class DepartmentController : Controller
    {
        StudentContext context = new StudentContext();
       //GetAll
        public ActionResult GetAll()
        {
            var departments = context.Departments.ToList();
            return View(departments);
        }
        //GetById
        public ActionResult GetById(int id)
        {
            var department = context.Departments.FirstOrDefault(x => x.Id == id);
            return View(department);
        }
        // new
        public ActionResult New()
        {
            return View();
        }
        // save
        [HttpPost]
        public ActionResult Save(Department department)
        {
            if (department.Name != null)
            {
                context.Departments.Add(department);
                context.SaveChanges();
                return RedirectToAction("GetAll");
            }
            else
            {
                return View("New", department);
            }
        }
        // Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var department = context.Departments.FirstOrDefault(x => x.Id == id);
            return View(department);
        }
        // editsave
        [HttpPost]
        public ActionResult EditSave(Department department)
        {
            if (department.Name != null)
            {
                context.Departments.Update(department);
                context.SaveChanges();
                return RedirectToAction("GetAll");
            }
            else
            {
                return View("Edit", department);
            }
        }
        // delete
        public ActionResult Delete(int id)
        {
            var department = context.Departments.FirstOrDefault(x => x.Id == id);
            context.Departments.Remove(department);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        // Details
        public ActionResult Details(int id)
        {
            var department = context.Departments.FirstOrDefault(x => x.Id == id);
            return View(department);
        }

    }
}
