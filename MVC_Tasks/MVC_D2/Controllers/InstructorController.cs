using Microsoft.AspNetCore.Mvc;
using MVC_D2.Context;


namespace MVC_D2.Controllers
{
    public class InstructorController : Controller
    {
        StudentContext context = new StudentContext();
        public ActionResult GetAll()
        {
            var instructors = context.Instructors.ToList();
            return View(instructors);
        }
        public ActionResult GetById(int id)
        {
            var instructor = context.Instructors.FirstOrDefault(x => x.Id == id);
            return View(instructor);
        }
    }
}
