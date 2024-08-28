using EF_Task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task.Context
{
    public class StudentContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database=EF_Task ;Trusted_Connection = true; Encrypt = false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Instructor_Course>().HasKey(ic => new { ic.instructor_id, ic.course_id });
            modelBuilder.Entity<Student_Course>().HasKey(sc => new { sc.student_id, sc.course_id });
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }


        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }


        public DbSet<Instructor_Course> InstructorCourses { get; set; }

        
        public DbSet<Student_Course> StudentCourses { get; set; }


    }
}
