using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_D2.Models
{
    public class Course
    {
        
        [Key]
        public int Id { get; set; }
        [MinLength(4,ErrorMessage ="At least 4 letters")]
        [MaxLength(50, ErrorMessage = "At Most 50 letters")]
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = " between 0 and 100")]
        public int? Degree { get; set; }
        [Range(0, 100, ErrorMessage = " between 0 and 100")]
        public int MinDegree { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<CourseResult> CourseResults { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
