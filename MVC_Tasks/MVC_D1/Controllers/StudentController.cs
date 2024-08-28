using Microsoft.AspNetCore.Mvc;
using MVC_Study.Context;

namespace MVC_Study.Controllers
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
            var student = context.Students.FirstOrDefault(x => x.SSN == id);
            return View(student);
        }
    }
}
