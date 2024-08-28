using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_D2.Models
{
    public class Instructor
    {
        // Id name salary imageurl address 

        [Key]
        public int Id { get; set; }
        [MinLength(4, ErrorMessage = "At least 4 letters")]
        [MaxLength(50, ErrorMessage = "At Most 50 letters")]
        public string Name { get; set; }
        [MinLength(4, ErrorMessage = "At least 4 letters")]
        [MaxLength(200, ErrorMessage = "At Most 200 letters")]
        public string? Address { get; set; }
        [Range(10000, 5000000, ErrorMessage = "between 10000 and 5000000")]
        public int? Salary { get; set; }
        public string? ImageUrl { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        public Course? Course { get; set; }
        
    }
}
