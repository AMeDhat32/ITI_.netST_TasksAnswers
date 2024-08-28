using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_D2.Models
{
    public class Instructor
    {
        // Id name salary imageurl address 

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public int Salary { get; set; }
        public string? ImageUrl { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        public Course? Course { get; set; }
        
    }
}
