using EF_Task.Context;
using EF_Task.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System.Runtime.Intrinsics.Arm;

namespace EF_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentContext db = new StudentContext();
            db.Database.EnsureCreated();

            // add departments

            Department d1 = new Department() { Name= "System Development" };
            Department d2 = new Department() { Name = "E-Learning" };
            Department d3 = new Department() { Name = "Java" };
            Department d4 = new Department() { Name = "Multimedia" };
            Department d5 = new Department() { Name = "Unix" };

            db.Departments.AddRange(d1, d2, d3, d4, d5);

            // add Students

            Student S1 = new Student() { Name = "Medhat",Address="Ismailia", DepartmentId = 1 };
            Student S2 = new Student() { Name = "Ali", Address = "Cairo", DepartmentId = 2 };
            Student S3 = new Student() { Name = "Mohamed", Address = "Alex", DepartmentId = 3 };
            Student S4 = new Student() { Name = "Mahmoud", Address = "Aswan", DepartmentId = 4 };
            Student S5 = new Student() { Name = "Omar", Address = "Suez", DepartmentId = 5 };

            db.Students.AddRange(S1, S2, S3, S4, S5);
            // add Courses
            Course C1 = new Course() { Name = "HTML" };
            Course C2 = new Course() { Name = "OOP" };
            Course C3 = new Course() { Name = "C#" };
            Course C4 = new Course() { Name = "ASP.Net" };
            Course C5 = new Course() { Name = "SQL Server" };

            db.Courses.AddRange(C1,C2,C3,C4,C5);

            //add Instructor
            Instructor I1 = new Instructor() { Name = "Ahmed", Salary = 5000 };
            Instructor I2 = new Instructor() { Name = "Ali", Salary = 6000 };
            Instructor I3 = new Instructor() { Name = "Mohamed", Salary = 7000 };
            Instructor I4 = new Instructor() { Name = "Mahmoud", Salary = 8000 };
            Instructor I5 = new Instructor() { Name = "Omar", Salary = 9000 };

            // add InstructorCourses
            Instructor_Course IC1 = new Instructor_Course() { instructor_id = 1, course_id = 1 };
            Instructor_Course IC2 = new Instructor_Course() { instructor_id = 2, course_id = 2 };
            Instructor_Course IC3 = new Instructor_Course() { instructor_id = 3, course_id = 3 };
            Instructor_Course IC4 = new Instructor_Course() { instructor_id = 4, course_id = 4 };
            Instructor_Course IC5 = new Instructor_Course() { instructor_id = 5, course_id = 5 };

            // add StudentCourses
            Student_Course SC1 = new Student_Course() { student_id = 1, course_id = 1 ,Grade=100000};
            Student_Course SC2 = new Student_Course() { student_id = 2, course_id = 2 ,Grade=0};
            Student_Course SC3 = new Student_Course() { student_id = 3, course_id = 3 ,Grade=0};
            Student_Course SC4 = new Student_Course() { student_id = 4, course_id = 4 , Grade = 0 };
            Student_Course SC5 = new Student_Course() { student_id = 5, course_id = 5 , Grade = 0 };






            db.SaveChanges();
        }
    }
}
