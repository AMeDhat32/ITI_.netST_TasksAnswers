using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task.Models
{
    public class Instructor_Course
    {
        
        [ForeignKey("Instructor")]
        public int instructor_id { get; set; }
       
        [ForeignKey("Course")]
        public int course_id { get; set; }
    }
}
