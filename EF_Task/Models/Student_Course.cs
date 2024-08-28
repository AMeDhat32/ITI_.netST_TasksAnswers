using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task.Models
{
    public class Student_Course
    {
       
        [ForeignKey("Student")]
        public int student_id { get; set; }
       
        [ForeignKey("Course")]
        public int course_id { get; set; }

        public int Grade { get; set; }
    }
}
